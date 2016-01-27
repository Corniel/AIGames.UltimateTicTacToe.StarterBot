using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIGames.UltimateTicTacToe.StarterBot.UnitTests
{
	[TestFixture]
	public class MacroBoardTest
	{
		[Test]
		public void Parse_Min100200010_GetsAnTypedArray()
		{
			var act = MacroBoard.Parse("-1,0,0,2,0,0,0,1,0");
			var exp = new MacroBoardValue[]
			{
				MacroBoardValue.Active,
				MacroBoardValue.NotTaken,
				MacroBoardValue.NotTaken,

				MacroBoardValue.Player2,
				MacroBoardValue.NotTaken,
				MacroBoardValue.NotTaken,

				MacroBoardValue.NotTaken,
				MacroBoardValue.Player1,
				MacroBoardValue.NotTaken,
			};

			CollectionAssert.AreEqual(exp, act);
		}
	}
}
