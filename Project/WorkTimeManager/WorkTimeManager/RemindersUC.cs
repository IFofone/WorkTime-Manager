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
    public partial class RemindersUc : UserControl
    {
        public event EventHandler<EventArgs> AddReminder;

        public List<Reminder> CurrentReminders { get; set; } = new List<Reminder>();
        public List<Reminder> DoneReminders { get; set; } = new List<Reminder>();

        public RemindersUc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds reminder to list of reminders
        /// </summary>
        public void AddToReminders(Reminder reminder, ref List<Reminder> reminders)
        {
            reminders.Add(reminder);
        }

        /// <summary>
        /// Adds done reminder to list of done reminders
        /// </summary>
        public void AddDoneReminder(Reminder reminder)
        {
            var doneReminders = DoneReminders;
            doneFLP.Controls.Add(new ReminderDoneUc(reminder));
            AddToReminders(reminder, ref doneReminders);

            if (!clearBtn.Visible)
            {
                clearBtn.Visible = true;
            }
        }

        /// <summary>
        /// Stops and removes reminder from list of reminders
        /// </summary>
        public void RemoveReminder(Reminder reminder, ref List<Reminder> reminders)
        {
            reminder.Stop();
            reminders.Remove(reminder);
        }

        /// <summary>
        /// Sorts (if needed) and displays all current reminders
        /// </summary>
        public void RefreshReminders()
        {
            if (CurrentReminders.Count > 1)
            {
                SortCurrentReminders();
            }

            DisplayReminders();
        }

        private void SortCurrentReminders()
        {
            CurrentReminders = CurrentReminders.OrderBy(reminder => reminder.GetRemainingTime()).ToList();
        }

        private void DisplayReminders()
        {
            foreach (ReminderCurrentUc currentFlpControl in currentFLP.Controls)
            {
                currentFlpControl.RefreshReminders -= OnRefreshReminders;
            }

            currentFLP.Controls.Clear();

            foreach (var reminder in CurrentReminders)
            {
                var reminderCurrentUc = new ReminderCurrentUc(reminder);
                reminderCurrentUc.RefreshReminders += OnRefreshReminders;
                currentFLP.Controls.Add(reminderCurrentUc);
            }
        }

        private void AddReminderBtn_Click(object sender, EventArgs e)
        {
            AddReminder?.Invoke(sender, EventArgs.Empty);
        }

        private void OnRefreshReminders(object sender, ReminderEventArgs e)
        {
            AddDoneReminder(e.Reminder);
            RefreshReminders();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            doneFLP.Controls.Clear();
            clearBtn.Visible = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (remindersCLB.Visible)
            {
                remindersCLB.Visible = false;
                removeBtn.Visible = false;
            }
            else
            {
                remindersCLB.Visible = true;
                remindersCLB.Items.Clear();

                foreach (var reminder in CurrentReminders)
                {
                    remindersCLB.Items.Add(reminder.Name);
                }

                removeBtn.Visible = true;
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var currentReminders = CurrentReminders;
            foreach (string reminderName in remindersCLB.CheckedItems)
            {
                RemoveReminder(currentReminders.Find(r => r.Name == reminderName), ref currentReminders);
            }

            RefreshReminders();

            remindersCLB.Items.Clear();
            remindersCLB.Visible = false;
            removeBtn.Visible = false;
        }
    }
}
