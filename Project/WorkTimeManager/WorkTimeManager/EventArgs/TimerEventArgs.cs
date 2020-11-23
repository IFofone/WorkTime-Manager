using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeManager
{
    public class TimerEventArgs : EventArgs
    {
        public int WorkTime { get; set; }
        public TimeUnit WorkTimeUnit { get; set; }
        public int BreakTime { get; set; }
        public TimeUnit BreakTimeUnit { get; set; }
    }
}
