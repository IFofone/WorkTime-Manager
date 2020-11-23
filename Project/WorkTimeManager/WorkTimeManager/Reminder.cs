using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public class Reminder
    {
        public event EventHandler<ReminderEventArgs> EndReminder;
        public event EventHandler<ReminderEventArgs> RefreshTimer; 

        public string Name { get; set; }
        public int Interval { get; set; }
        public bool Repeat { get; set; }

        private readonly Timer _timer;
        private int _currentInterval;

        public Reminder(string name, int interval, bool repeat)
        {
            Name = name;
            Interval = interval;
            Repeat = repeat;

            _timer = new Timer { Interval = 60000 };    // 1 minute
            _timer.Tick += Timer_Tick;
            Restart();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _currentInterval--;

            if (_currentInterval < 0)
            {
                Stop();
                Task.Run(() => MessageBox.Show($"Reminder for {Name}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information));

                if (Repeat)
                {
                    Restart();
                }
                else
                {
                    EndReminder?.Invoke(sender, new ReminderEventArgs { Reminder = this });
                }
            }

            RefreshTimer?.Invoke(sender, new ReminderEventArgs { Reminder = this });
        }

        public int GetRemainingTime()
        {
            return _currentInterval;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Restart()
        {
            _currentInterval = Interval - 1;
            Start();
        }
    }
}
