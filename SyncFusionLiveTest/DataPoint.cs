using System;

namespace SyncFusionLiveTest
{
	public class DataPoint
	{
		public DataPoint()
		{
		}

		public DataPoint(DateTime x, double y)
		{
			X = x;
			Y = y;
		}

		public DateTime X { get; set; }

		public double Y { get; set; }
	}
}
