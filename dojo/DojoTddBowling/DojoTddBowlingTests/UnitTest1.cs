using NUnit.Framework;


namespace DojoTddBowlingTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TestGutterGame()
		{
			BowlingGame game = new BowlingGame();
			for (int i = 0; i < 20; i++)
			{
				game.Roll(0);
			}
			Assert.AreEqual(0, game.Score());
		}

		[Test]
		public void TestAllOnes()
		{
			BowlingGame game = new BowlingGame();

			for (int i = 0; i < 20; i++)
			{
				game.Roll(1);
			}

			Assert.AreEqual(20, game.Score());
		}
	}
}