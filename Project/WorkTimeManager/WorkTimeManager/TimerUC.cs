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
    public partial class TimerUC : UserControl
    {
        public event EventHandler<EventArgs> EndTimer;

        private readonly Time _workTime;
        private readonly Time _breakTime;

        private bool _isWorkTime = true;

        private int _hours = 0;
        private int _minutes = 0;
        private int _seconds = 0;

        public TimerUC(TimerEventArgs timerInfo)
        {
            InitializeComponent();

            _workTime = FormatTime(timerInfo.WorkTime, timerInfo.WorkTimeUnit);
            _breakTime = FormatTime(timerInfo.BreakTime, timerInfo.BreakTimeUnit);

            SetTimer(_workTime);

            progressBar1.Maximum = _seconds + _minutes * 60 + _hours * 3600;

            workTimeLbl.Text = timerInfo.WorkTime.ToString();
            breakTimeLbl.Text = timerInfo.BreakTime.ToString();
        }

        private static Time FormatTime(int time, TimeUnit timeUnit)
        {
            var seconds = 0;
            var minutes = 0;

            if (timeUnit == TimeUnit.Seconds)
            {
                seconds = time % 60;
                time /= 60;
            }

            if (timeUnit == TimeUnit.Seconds || timeUnit == TimeUnit.Minutes)
            {
                minutes = time % 60;
                time /= 60;
            }
            
            var hours = time;

            return new Time { Hours = hours, Minutes = minutes, Seconds = seconds };
        }

        private void SetTimer(Time time)
        {
            secondsLbl.Text = CorrectTime(time.Seconds);
            minutesLbl.Text = CorrectTime(time.Minutes);
            hoursLbl.Text = CorrectTime(time.Hours);

            _seconds = time.Seconds;
            _minutes = time.Minutes;
            _hours = time.Hours;
        }

        private static string CorrectTime(int time)
        {
            var correctTime = time.ToString();

            if (time < 10)
            {
                correctTime = "0" + correctTime;
            }

            return correctTime;
        }

        private void RefreshTimer()
        {
            timer.Stop();
            string question;

            if (_isWorkTime)
            {
                _isWorkTime = false;
                SetTimer(_breakTime);
                stateLbl.Text = "BREAKTIME";

                question = "Ready to take a break!? \nIf not, then finish your work and manually start the timer.";
            }
            else
            {
                _isWorkTime = true;
                SetTimer(_workTime);
                stateLbl.Text = "WORKTIME";

                question = "Ready to work!? \nIf not, then get ready and manually start the timer.";
            }

            var answer = MessageBox.Show(question, "Time's up!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            progressBar1.Maximum = _seconds + _minutes * 60 + _hours * 3600;
            progressBar1.Value = 0;

            if (answer == DialogResult.Yes)
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            _seconds--;
            if (_seconds < 0)
            {
                _minutes--;
                _seconds = 59;
            }

            if (_minutes < 0)
            {
                _hours--;
                _minutes = 59;
            }

            secondsLbl.Text = CorrectTime(_seconds);
            minutesLbl.Text = CorrectTime(_minutes);
            hoursLbl.Text = CorrectTime(_hours);

            if (_seconds == 0 && _minutes == 0 && _hours == 0)
            {
                RefreshTimer();
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            EndTimer?.Invoke(sender, EventArgs.Empty);
            timer.Stop();
        }
    }
}
