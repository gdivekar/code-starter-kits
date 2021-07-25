using BowlingBall.Base;
using System.Collections.Generic;

namespace BowlingBall
{
	public class Game
	{
		private const int numberOfFrames = 10;

		private readonly List<int> rolls;
		private readonly List<IFrame> frames;
		private readonly IGameScore gameScore;
		public Game(IGameSetup gameSetup, IGameScore score)
		{
			this.gameScore = score;
			frames = gameSetup.GetFrames(numberOfFrames);
			this.rolls = new List<int>();
		}

		public Game() : this(new GameSetup(), new GameScore()) // Manual Dependency Injection instead of using DI container
		{

		}

		public void Roll(int pins)
		{
			rolls.Add(pins);
		}

		public int GetScore()
		{
			return gameScore.CalculateScore(frames, rolls);
		}

	}
}
