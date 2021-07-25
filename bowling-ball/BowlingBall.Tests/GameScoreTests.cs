using System;
using System.Collections.Generic;
using BowlingBall.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace BowlingBall.Tests
{
	[TestClass]
	public class GameScoreTests
	{
		int numberOfFrames;
		private GameScore score;
		private List<int> rolls;
		private List<IFrame> frames;
		[TestInitialize]
		public void Init()
		{
			numberOfFrames = 10;
			score = new GameScore();
			rolls = new List<int>();
			frames = new List<IFrame>();
			for (int i = 1; i < numberOfFrames + 1; i++)
			{
				frames.Add(new Frame() { Index = i, Rolls = new List<int>() });
			}
		}

		[TestMethod]
		public void CalculateScore_ValidRolls_Pass()
		{
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(1);
			rolls.Add(5);
			rolls.Add(5);
			rolls.Add(7);
			rolls.Add(2);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(0);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(9);
			rolls.Add(1);
			rolls.Add(10);

			Assert.AreEqual(187, score.CalculateScore(frames, rolls));
		}

		[TestMethod]
		public void CalculateScore_AllStrikes_Pass()
		{

			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);

			Assert.AreEqual(300, score.CalculateScore(frames, rolls));
		}

		[TestMethod]
		public void CalculateScore_AllOpen_Pass()
		{

			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);
			rolls.Add(1);

			Assert.AreEqual(20, score.CalculateScore(frames, rolls));
		}

		[TestMethod]
		public void CalculateScore_AllSpare_Pass()
		{
			
			rolls.Add(9);
			rolls.Add(1);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(7);
			rolls.Add(3);
			rolls.Add(5);
			rolls.Add(5);
			rolls.Add(6);
			rolls.Add(4);
			rolls.Add(7);
			rolls.Add(3);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(3);
			rolls.Add(7);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(1);
			rolls.Add(9);
			rolls.Add(0);
			Assert.AreEqual(153, score.CalculateScore(frames, rolls));
		}

		//Remove
		[TestMethod]
		public void CalculateScore_EndsWithOpenFrame_Pass()
		{
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(1);
			rolls.Add(5);
			rolls.Add(5);
			rolls.Add(7);
			rolls.Add(2);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(0);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(5);
			rolls.Add(4);

			Assert.AreEqual(172, score.CalculateScore(frames, rolls));
		}

		[TestMethod]
		public void CalculateScore_EndsWithSpareFrame_Pass()
		{
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(1);
			rolls.Add(5);
			rolls.Add(5);
			rolls.Add(7);
			rolls.Add(2);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(10);
			rolls.Add(9);
			rolls.Add(0);
			rolls.Add(8);
			rolls.Add(2);
			rolls.Add(5);
			rolls.Add(5);
			rolls.Add(10);

			Assert.AreEqual(183, score.CalculateScore(frames, rolls));
		}

	}
}
