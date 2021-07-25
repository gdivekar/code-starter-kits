using BowlingBall.Base;
using System.Collections.Generic;
using System.Linq;
namespace BowlingBall
{
	public class Frame : IFrame
	{
		public int Index { get; set; }

		public List<int> Rolls { get; set; }

		public int Bonus { get; set; }

		public int CalculateScore()
		{
			int frameScore = 0;
			if (this.Rolls?.Count > 0)
			{
				frameScore = this.Rolls.Sum(c => c) + Bonus;
			}
			return frameScore;
		}

		public Common.FrameState GetState()
		{
			Common.FrameState state = Common.FrameState.Open;
			if (this.Rolls?.Count > 0)
			{
				int? totalScore = this.Rolls.Sum(c => c);
				if (this.Rolls.Count == 1 && totalScore.GetValueOrDefault() == 10)
				{
					state = Common.FrameState.Strike;
				}
				if (this.Rolls.Count == 2 && totalScore.GetValueOrDefault() == 10)
				{
					state = Common.FrameState.Spare;
				}
			}
			return state;
		}
	}
}