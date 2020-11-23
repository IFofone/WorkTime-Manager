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
    public partial class CreateTimerUc : UserControl
    {
        public event EventHandler<TimerEventArgs> CreateTimer;

        private readonly List<string> _timeUnits = new List<string>
        {
            "seconds",
            "minutes",
            "hours"
        };

        public CreateTimerUc()
        {
            InitializeComponent();

            SetTimeComboBox(workCB);
            SetTimeComboBox(breakCB);
        }

        private void SetTimeComboBox(ComboBox comboBox)
        {
            foreach (var unit in _timeUnits)
            {
                comboBox.Items.Add(unit);
            }

            comboBox.SelectedIndex = 1;
        }

        private static TimeUnit GetTimeUnit(ComboBox comboBox)
        {
            TimeUnit timeUnit;
            switch (comboBox.Text)
            {
                case "minutes":
                    timeUnit = TimeUnit.Minutes;
                    break;

                case "seconds":
                    timeUnit = TimeUnit.Seconds;
                    break;

                case "hours":
                    timeUnit = TimeUnit.Hours;
                    break;

                default:
                    timeUnit = TimeUnit.Invalid;
                    break;
            }

            return timeUnit;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var workTime = 0;
            var breakTime = 0;
            var errorMessage = new StringBuilder();

            if (radioBtn1.Checked)
            {
                workTime = 25;
                breakTime = 6;
            }
            else if (radioBtn2.Checked)
            {
                workTime = 52;
                breakTime = 17;
            }
            else if (radioBtn3.Checked)
            {
                workTime = 20;
                breakTime = 20;
            }
            else if (customRadioBtn.Checked) // Custom
            {
                if (!int.TryParse(customWorkTimeTB.Text, out workTime))
                {
                    errorMessage.Append("Invalid work time format!\n");
                    customWorkTimeTB.Text = string.Empty;
                }

                if (!int.TryParse(customBreakTimeTB.Text, out breakTime))
                {
                    errorMessage.Append("Invalid break time format!\n");
                    customBreakTimeTB.Text = string.Empty;
                }
            }
            else
            {
                errorMessage.Append("No technique chosen!\n");
            }

            var workTimeUnit = GetTimeUnit(workCB);
            var breakTimeUnit = GetTimeUnit(breakCB);
            if (workTimeUnit == TimeUnit.Invalid || breakTimeUnit == TimeUnit.Invalid)
            {
                errorMessage.Append("Invalid time unit!\n");
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateTimer?.Invoke(nextBtn, new TimerEventArgs { WorkTime = workTime, WorkTimeUnit = workTimeUnit, BreakTime = breakTime, BreakTimeUnit = breakTimeUnit });
            }
        }

        private void CustomRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (customRadioBtn.Checked)
            {
                customPanel.Visible = true;
                nextBtn.Location = new Point(nextBtn.Location.X, nextBtn.Location.Y + customPanel.Height);
            }
            else
            {
                customPanel.Visible = false;
                nextBtn.Location = new Point(nextBtn.Location.X, nextBtn.Location.Y - customPanel.Height);
            }
        }
    }
}
