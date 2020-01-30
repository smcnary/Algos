using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class Timing
	{
		TimeSpan _startingTime;
		TimeSpan _duration;

		public Timing()
		{
			_startingTime = new TimeSpan(0);
			_duration = new TimeSpan(0);
		}

		public void StopTime()
		{
			_duration =
					Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(_startingTime);
		}

		public void StartTime() {
			GC.Collect();
			GC.WaitForPendingFinalizers();
			_startingTime =
					Process.GetCurrentProcess().Threads[0].
					        UserProcessorTime;
		}
		public TimeSpan Result() => _duration;
	}
}
