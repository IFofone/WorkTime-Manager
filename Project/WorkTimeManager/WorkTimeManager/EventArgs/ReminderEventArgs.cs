using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeManager
{
    public class ReminderEventArgs : EventArgs
    {
        public Reminder Reminder { get; set; }
    }
}
