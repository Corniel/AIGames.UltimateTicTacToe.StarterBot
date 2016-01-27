using AIGames.UltimateTicTacToe.StarterBot.Communication;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AIGames.UltimateTicTacToe.StarterBot
{
	public class Starter : IBot
	{
		public Starter()
		{
			Rnd = new Random();
		}
		public Settings Settings { get; set; }
		public GameState State { get; set; }
		public Random Rnd { get; set; }

		void IBot.ApplySettings(Settings settings)
		{
			Settings = settings;
		}

		void IBot.Update(GameState state)
		{
			State = state;
		}

		public BotResponse GetResponse(TimeSpan time)
		{

			var candidates = new List<Move>();

			for (var y = 0; y < 9; y++)
			{
				for (var x = 0; x < 9; x++)
				{
					var tiny = 3 * (y / 3) + (x % 3);
					
					if (State.Macro[tiny] == MacroBoardValue.Active && 
						State.Meta[x, y] == 0)
					{
						candidates.Add(new Move(x, y));
					}
				}
			}

			var move = candidates.OrderBy(c => Rnd.Next()).FirstOrDefault();

			var r = new BotResponse()
			{
				Move = new MoveInstruction(move),
				Log = "Add some usefull logging here.",
			};
			return r;
		}
	}
}
