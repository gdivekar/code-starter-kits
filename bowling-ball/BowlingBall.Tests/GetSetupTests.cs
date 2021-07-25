using System;
using System.Collections.Generic;
using BowlingBall.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BowlingBall.Tests
{
	[TestClass]
	public class GameSetupTests
	{

		[TestMethod]
		public void GetFrames_WithValidInput_Pass()
		{
			int numberOfFrames = 5;
			GameSetup setup = new GameSetup();
			setup.GetFrames(numberOfFrames);
			List<IFrame> frames = new List<IFrame>();
			frames.Add(new Frame() { Index = 1, Rolls = new List<int>() });
			frames.Add(new Frame() { Index = 2, Rolls = new List<int>() });
			frames.Add(new Frame() { Index = 3, Rolls = new List<int>() });
			frames.Add(new Frame() { Index = 4, Rolls = new List<int>() });
			frames.Add(new Frame() { Index = 5, Rolls = new List<int>() });
			Assert.AreEqual(numberOfFrames, setup.GetFrames(numberOfFrames).Count);
		}
	}
}
