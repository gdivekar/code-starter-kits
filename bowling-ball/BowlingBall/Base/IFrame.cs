using System.Collections.Generic;

namespace BowlingBall.Base
{
	public interface IFrame
	{
		int Index { get; set; }		

		int Bonus { get; set; }

		List<int> Rolls { get; set; }

		int CalculateScore();		

		Common.FrameState GetState();
	}
}
