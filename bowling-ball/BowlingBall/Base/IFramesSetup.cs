using System.Collections.Generic;

namespace BowlingBall.Base
{
	public interface IGameSetup
	{
		List<IFrame> GetFrames(int numberOfFrames);
	}
}
