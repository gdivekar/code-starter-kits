using System;
using System.Collections.Generic;
using BowlingBall.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BowlingBall.Tests
{
	[TestClass]
	public class GameFixture
	{

		private Game game;

		[TestInitialize]
		public void Init()
		{
			game = new Game();
		}
		
		[TestMethod]
		public void Gutter_game_score_should_be_Real_test()
		{

			//This is more of a Integration test than Unit Test
			game.Roll(2);
			game.Roll(0);
			game.Roll(3);
			game.Roll(0);
			game.Roll(8);
			game.Roll(1);
			game.Roll(2);
			game.Roll(0);
			game.Roll(3);
			game.Roll(0);
			game.Roll(8);
			game.Roll(0);
			game.Roll(1);
			game.Roll(2);
			game.Roll(3);
			game.Roll(4);
			game.Roll(3);
			game.Roll(7);
			game.Roll(2);
			game.Roll(0);
			Assert.AreEqual(51, game.GetScore());
		}
		
	}
}
