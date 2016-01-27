using System;
using System.Diagnostics;

namespace AIGames.UltimateTicTacToe.StarterBot.Communication
{
	public struct FieldInstruction : IInstruction
	{
		public FieldInstruction(String field) 
		{
			str = field;
			m_Field = MetaBoard.Parse(field); 
		}

		public byte[,] Field { get { return m_Field; } }
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly byte[,] m_Field;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly String str;

		public override string ToString() 
		{
			return String.Format("update game field {0}", str);
		}

		internal static IInstruction Parse(string[] splited)
		{
			return new FieldInstruction(splited[3]);
		}
	}
}
