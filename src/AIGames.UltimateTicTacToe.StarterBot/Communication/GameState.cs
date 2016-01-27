using System;
using System.Collections.Generic;
using System.Linq;

namespace AIGames.UltimateTicTacToe.StarterBot.Communication
{
	public class GameState
	{
		public GameState()
		{
			Meta = MetaBoard.New();
			Macro = MacroBoard.New();
		}
		/// <summary>The current round.</summary>
		public int Round { get; set; }

		/// <summary>The meta board of the current state.</summary>
		public byte[,] Meta { get; set; }

		/// <summary>The macro board of the current state.</summary>
		public MacroBoardValue[] Macro { get; set; }

		/// <summary>Applies the instructions to the state.</summary>
		public bool Apply(IInstruction instruction)
		{
			if (Mapping.ContainsKey(instruction.GetType()))
			{
				Mapping[instruction.GetType()].Invoke(instruction, this);
				return true;
			}
			return false;
		}

		public static GameState Create(IEnumerable<IInstruction> instructions)
		{
			var state = new GameState();

			foreach (var instruction in instructions.Where(i => Mapping.ContainsKey(i.GetType())))
			{
				Mapping[instruction.GetType()].Invoke(instruction, state);
			}
			return state;
		}

		private static Dictionary<Type, Action<IInstruction, GameState>> Mapping = new Dictionary<Type, Action<IInstruction, GameState>>()
		{
			{ 
				typeof(MacroboardInstruction), (instruction, state) =>
				{
					var inst = (MacroboardInstruction)instruction;
					state.Macro = inst.Values;
				}
			},
			{ 
				typeof(FieldInstruction), (instruction, state) =>
				{
					var inst = (FieldInstruction)instruction;
					state.Meta = inst.Field;
				}
			},
			{ 
				typeof(RoundInstruction), (instruction, state) => 
				{ 
					state.Round = ((RoundInstruction)instruction).Value; 
				}
			},
		};
	}
}
