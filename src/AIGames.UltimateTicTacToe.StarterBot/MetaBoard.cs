using System;
using System.Linq;

namespace AIGames.UltimateTicTacToe.StarterBot
{
	public static class MetaBoard
	{
		/// <summary>Gets a new empty meta board.</summary>
		public static byte[,] New() { return new byte[9,9]; }
		
		/// <summary>Parses a meta board.</summary>
		public static byte[,] Parse(string str)
		{
			var bytes = str
				.Split(',')
				.Select(digit => byte.Parse(digit))
				.ToArray();

			var board = New();
			
			var index = 0;
			for (var y = 0; y < 9; y++)
			{
				for (var x = 0; x < 9; x++)
				{
					board[y, x] = bytes[index++];
				}
			}
			return board;
		}
	}
}
