using System;
using System.Linq;

namespace AIGames.UltimateTicTacToe.StarterBot
{
	public enum MacroBoardValue
	{
		Active = -1,
		NotTaken = 0,
		Player1 = 1,
		Player2 = 2,
	}
	public static class MacroBoard
	{
		public static MacroBoardValue[] New()
		{
			return new MacroBoardValue[9];
		}

		public static MacroBoardValue[] Parse(string str)
		{
			return str
				.Split(',')
				.Select(digit => (MacroBoardValue)Enum.Parse(typeof(MacroBoardValue), digit))
				.ToArray();
		}
	}
}
