using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class BaseForm : Form
    {
        private UserControl _currentUc;
        private AccountInfoUc _accountInfoUc;
        private readonly RemindersUc _remindersUc = new RemindersUc();
        private TimerUC _timerUc;

        public BaseForm()
        {
            InitializeComponent();

            UnlagDatabaseAsync();
            LoadUserControl(new HomeUc());
            _remindersUc.AddReminder += OnAddReminder;
        }

        private static async void UnlagDatabaseAsync()
        {
            using (var dbContext = new DbContext())
            {
                await Task.Run(() => dbContext.Users.ToList());
            }
        }

        private LoginUc CreateLoginUc()
        {
            var loginUc = new LoginUc();
            loginUc.LoginSuccess += OnLoginSuccess;
            loginUc.RegisterClick += OnRegisterClick;

            return loginUc;
        }

        public void LoadUserControl(UserControl uc)
        {
            if (_currentUc != null)
            {
                visualPanel.Controls.Remove(_currentUc);
            }

            _currentUc = uc;
            if (_currentUc == null)
            {
                return;
            }

            _currentUc.Dock = DockStyle.Fill;
            visualPanel.Controls.Add(_currentUc);
            visualPanel.Tag = _currentUc;
            _currentUc.Show();
        }

        private void SetTitle(string title)
        {
            titleLabel.Text = title;
        }

        private void SetUserName(string name)
        {
            nameLabel.Text = name;
        }

        private void RemindersBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(_remindersUc);
            SetTitle("Reminders");
        }

        private void OnAddReminder(object sender, EventArgs e)
        {
            var createReminderUc = new CreateReminderUc(_remindersUc.CurrentReminders);
            createReminderUc.CreateReminder += OnCreateReminder;

            LoadUserControl(createReminderUc);
        }

        private void OnCreateReminder(object sender, ReminderEventArgs e)
        {
            var reminder = e.Reminder;
            reminder.EndReminder += OnEndReminder;

            var currentReminders = _remindersUc.CurrentReminders;
            _remindersUc.AddToReminders(e.Reminder, ref currentReminders);
            _remindersUc.RefreshReminders();

            LoadUserControl(_remindersUc);
        }

        private void OnEndReminder(object sender, ReminderEventArgs e)
        {
            var currentReminders = _remindersUc.CurrentReminders;
            _remindersUc.RemoveReminder(e.Reminder, ref currentReminders);
            _remindersUc.AddDoneReminder(e.Reminder);
            _remindersUc.RefreshReminders();
        }

        private void OnLoginClick(object sender, EventArgs e)
        {
            var loginUc = CreateLoginUc();
            LoadUserControl(loginUc);
        }

        private void OnLoginSuccess(object sender, UserEventArgs e)
        {
            _accountInfoUc = new AccountInfoUc(e.User);
            _accountInfoUc.Logout += OnLogout;
            LoadUserControl(_accountInfoUc);
            SetUserName(e.User.Name);
        }

        private void OnLogout(object sender, EventArgs e)
        {
            SetUserName(string.Empty);
            _accountInfoUc = null;
            var loginUc = CreateLoginUc();
            LoadUserControl(loginUc);
        }

        private void OnRegisterClick(object sender, EventArgs e)
        {
            var registerUc = new RegisterUc();
            registerUc.LoginClick += OnLoginClick;
            registerUc.RegisterSuccess += OnRegisterSuccess;
            LoadUserControl(registerUc);
        }

        private void OnRegisterSuccess(object sender, EventArgs e)
        {
            var loginUc = CreateLoginUc();
            LoadUserControl(loginUc);
        }

        private void TimerBtn_Click(object sender, EventArgs e)
        {
            if (_timerUc == null)
            {
                var createTimerUc = new CreateTimerUc();
                createTimerUc.CreateTimer += OnCreateTimer;
                LoadUserControl(createTimerUc);
            }
            else
            {
                LoadUserControl(_timerUc);
            }

            SetTitle("Timer");
        }
        private void OnCreateTimer(object sender, TimerEventArgs e)
        {
            _timerUc = new TimerUC(e);
            _timerUc.EndTimer += OnEndTimer;
            LoadUserControl(_timerUc);
        }

        private void OnEndTimer(object sender, EventArgs e)
        {
            _timerUc = null;
            TimerBtn_Click(sender, e);
        }

        private void LogoLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HomeUc());
            SetTitle("Home");
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            if (_accountInfoUc != null)   // User already signed in
            {
                LoadUserControl(_accountInfoUc);
            }
            else
            {
                var loginUc = CreateLoginUc();
                LoadUserControl(loginUc);
            }

            SetTitle("Account");
        }
    }
}
