using System;
using System.Diagnostics;
using System.Linq;

namespace AIGames.UltimateTicTacToe.StarterBot.Communication
{
	public struct MacroboardInstruction : IInstruction
	{
		public MacroboardInstruction(MacroBoardValue[] values)
		{
			m_Values = values;
		}

		public MacroBoardValue[] Values { get { return m_Values; } }
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly MacroBoardValue[] m_Values;

		public override string ToString() 
		{
			return String.Format("update game field {0}", String.Join(",", Values.Select(val => (int)val)));
		}

		internal static IInstruction Parse(string[] splited)
		{
			var macroboard = MacroBoard.Parse(splited[3]);
			return new MacroboardInstruction(macroboard);
		}
	}
}
