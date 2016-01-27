using NUnit.Framework;

namespace AIGames.UltimateTicTacToe.StarterBot.UnitTests
{
	[TestFixture]
	public class MetaBoardTest
	{
		[Test]
		public void Parse_BoardWith3FieldFilled_AreEqual()
		{
			var input = 
				"0,0,0,0,0,0,0,0,0,"+
				"1,0,0,0,0,0,0,0,0,"+
				"0,0,0,0,0,0,0,0,0,"+

				"0,0,0,2,0,0,0,0,0,"+
				"0,0,0,0,0,0,0,0,0,"+
				"0,0,0,0,0,0,0,0,0,"+
				
				"0,0,0,0,0,0,0,0,0,"+
				"0,0,0,0,0,0,0,1,0,"+
				"0,0,0,0,0,0,0,0,0";

			var act = MetaBoard.Parse(input);

			var exp = new byte[,]
			{
				{0, 0, 0,  0, 0, 0,  0, 0, 0 },
				{1, 0, 0,  0, 0, 0,  0, 0, 0 },
				{0, 0, 0,  0, 0, 0,  0, 0, 0 },

				{0, 0, 0,  2, 0, 0,  0, 0, 0 },
				{0, 0, 0,  0, 0, 0,  0, 0, 0 },
				{0, 0, 0,  0, 0, 0,  0, 0, 0 },

				{0, 0, 0,  0, 0, 0,  0, 0, 0 },
				{0, 0, 0,  0, 0, 0,  0, 1, 0 },
				{0, 0, 0,  0, 0, 0,  0, 0, 0 },
			};

			CollectionAssert.AreEqual(exp, act);
		}
	}
}
