using System;
using System.Collections.Generic;
using BowlingBall.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BowlingBall.Tests
{
	[TestClass]	
	public class FrameTests
	{
		private IFrame frame;

		[TestInitialize]
		public void Init()
		{
			frame = new Frame();
			frame.Rolls = new List<int>();
		}

		[TestMethod]
		public void CalculateScore_ValidRolls_Pass()
		{
			frame.Rolls.Add(1);
			frame.Rolls.Add(2);
			Assert.AreEqual(3, frame.CalculateScore());	
		
		}

		[TestMethod]
		public void CalculateScore_ValidRollsWithBonus_Pass()
		{
			frame.Rolls.Add(8);
			frame.Rolls.Add(2);
			frame.Bonus = 5;
			Assert.AreEqual(15, frame.CalculateScore());

		}

		[TestMethod]
		public void Frame_Has_SpareState()
		{
			frame.Rolls.Add(8);
			frame.Rolls.Add(2);
			Assert.AreEqual(Common.FrameState.Spare, frame.GetState());

		}

		[TestMethod]
		public void Frame_Has_StrikeState()
		{
			frame.Rolls.Add(10);
			Assert.AreEqual(Common.FrameState.Strike, frame.GetState());

		}

		[TestMethod]
		public void Frame_Has_OpenState()
		{
			frame.Rolls.Add(7);
			frame.Rolls.Add(1);
			Assert.AreEqual(Common.FrameState.Open, frame.GetState());

		}

	}
}
