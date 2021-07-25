using BowlingBall.Common;
using System.Collections.Generic;
using System.Linq;
namespace BowlingBall.Base
{
	public class GameScore : IGameScore
	{
		public int CalculateScore(List<IFrame> frames, List<int> rolls)
		{
			int gameScore = 0;
			int rollIndex = 0;
			int frameIndex = 0;
			int numberOfFrames = frames.Count;

			FrameState previousFrameState = FrameState.Open;

			foreach (var frame in frames)
			{
				// Calculate bonus for previous frames
				if (previousFrameState == FrameState.Strike)
				{
					frames[frameIndex - 1].Bonus += rolls[rollIndex] + rolls[rollIndex + 1];
				}
				else if (previousFrameState == FrameState.Spare)
				{
					frames[frameIndex - 1].Bonus += rolls[rollIndex];
				}

				frame.Rolls.Add(rolls[rollIndex]);

				if (rolls[rollIndex] == 10) // strike
				{
					previousFrameState = FrameState.Strike;
					rollIndex += 1;
				}
				else // Spare or Open 
				{
					frame.Rolls.Add(rolls[rollIndex + 1]);
					previousFrameState = frame.GetState();
					rollIndex += 2;
				}

				frameIndex += 1;

			}
			// Calculate score in case of extra roll in last frame
			if (rollIndex <= rolls.Count - 1)
			{
				if (previousFrameState == FrameState.Strike)
				{
					frames[numberOfFrames - 1].Rolls.Add(rolls[rollIndex]);
					frames[numberOfFrames - 1].Bonus += rolls[rollIndex + 1];
				}
				else
				{
					frames[numberOfFrames - 1].Bonus += rolls[rollIndex];
				}

			}
			gameScore = frames.Sum(c => c.CalculateScore());

			return gameScore;
		}
	}
}
