using BowlingBall.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
	public class GameSetup : IGameSetup
	{
		public List<IFrame> GetFrames(int numberOfFrames)
		{
			List<IFrame> frames = new List<IFrame>(numberOfFrames);
			for (int i = 1; i < numberOfFrames + 1; i++)
			{
				frames.Add(new Frame() { Index = i, Rolls = new List<int>() });
			}
			return frames;
		}
	}
}
