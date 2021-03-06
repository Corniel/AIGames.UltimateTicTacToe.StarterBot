﻿using System;
using System.Collections.Generic;

namespace AIGames.UltimateTicTacToe.StarterBot.Communication
{
	public class Settings
	{
		public PlayerName YourBot { get; set; }
		public PlayerName OppoBot
		{
			get
			{
				switch (YourBot)
				{
					case PlayerName.Player1: return PlayerName.Player2;
					case PlayerName.Player2: return PlayerName.Player1;
					case PlayerName.None:
					default: return PlayerName.None;
				}
			}
		}

		public bool Apply(IInstruction instruction)
		{
			if (Mapping.ContainsKey(instruction.GetType()))
			{
				Mapping[instruction.GetType()].Invoke(instruction, this);
				return true;
			}
			return false;
		}

		private static Dictionary<Type, Action<IInstruction, Settings>> Mapping = new Dictionary<Type, Action<IInstruction, Settings>>()
		{
			{ typeof(YourBotInstruction), (instruction, settings) =>{ settings.YourBot = ((YourBotInstruction)instruction).Name; }},

		};
	}
}
