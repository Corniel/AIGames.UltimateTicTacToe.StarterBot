namespace AIGames.UltimateTicTacToe.StarterBot
{
	/// <summary>Logic for a move of a tiny board.</summary>
	public struct Move
	{
		/// <summary>Represents the center of the board.</summary>
		public static readonly Move Center = new Move(4, 4);

		/// <summary>Creates a new move.</summary>
		public Move(int x, int y)
		{
			X = (byte)x;
			Y = (byte)y;
		}

		/// <summary>Gets the X coordinate of the move.</summary>
		public readonly byte X;
		/// <summary>Gets the Y coordinate of the move.</summary>
		public readonly byte Y;

		/// <summary>Represents the move as string.</summary>
		public override string ToString()
		{
			return string.Format("[{0}, {1}]", X, Y);
		}
	}
}
