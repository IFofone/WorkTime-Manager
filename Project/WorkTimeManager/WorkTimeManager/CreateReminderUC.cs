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
    public partial class CreateReminderUc : UserControl
    {
        public event EventHandler<ReminderEventArgs> CreateReminder;

        private readonly List<Reminder> _currentReminders;
            
        public CreateReminderUc(List<Reminder> currentReminders)
        {
            InitializeComponent();

            _currentReminders = currentReminders;
        }

        private bool CheckNameUnique(string name)
        {
            return _currentReminders.All(reminder => !name.Equals(reminder.Name));
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var errorMessage = new StringBuilder();

            var name = nameBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                errorMessage.Append("Name cannot be empty!\n");
            }
            else if (!CheckNameUnique(name))
            {
                errorMessage.Append("Name already used!\n");
                nameBox.Text = string.Empty;
            }

            if (!int.TryParse(intervalBox.Text, out var interval))
            {
                errorMessage.Append("Interval can contain whole numbers only!\n");
                intervalBox.Text = string.Empty;
            }
            else if (interval < 1)
            {
                errorMessage.Append("Interval can contain positive numbers only!\n");
                intervalBox.Text = string.Empty;
            }

            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var reminder = new Reminder(name, interval, repeatYesRBtn.Checked);

            CreateReminder?.Invoke(sender, new ReminderEventArgs { Reminder = reminder });
        }
    }
}
