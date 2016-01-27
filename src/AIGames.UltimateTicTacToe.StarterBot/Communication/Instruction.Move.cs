namespace AIGames.UltimateTicTacToe.StarterBot.Communication
{
	public class MoveInstruction : IInstruction
	{
		public MoveInstruction(Move move)
		{
			Move = move;
		}

		public readonly Move Move;

		public override string ToString()
		{
			return string.Format("place_move {0} {1}", Move.X, Move.Y);
		}
	}
}
