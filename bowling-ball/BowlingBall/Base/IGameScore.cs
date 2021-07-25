using System.Collections.Generic;

namespace BowlingBall.Base
{
	public interface IGameScore
	{
		int CalculateScore(List<IFrame> frames, List<int> rolls);
	}
}
