using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class ReminderCurrentUc : UserControl
    {
        public event EventHandler<ReminderEventArgs> RefreshReminders; 

        private readonly Reminder _reminder;

        public ReminderCurrentUc(Reminder reminder)
        {
            InitializeComponent();

            _reminder = reminder;
            _reminder.RefreshTimer += OnRefreshTimer;

            nameLbl.Text = _reminder.Name;
            timeLbl.Text = _reminder.GetRemainingTime().ToString();
        }

        private void OnRefreshTimer(object sender, ReminderEventArgs e)
        {
            var remainingTime = _reminder.GetRemainingTime();
            if (remainingTime == _reminder.Interval - 1 || remainingTime == -1) // Repeats or is done
            {
                RefreshReminders?.Invoke(sender, e);
            }

            timeLbl.Text = remainingTime.ToString();
        }
    }
}
