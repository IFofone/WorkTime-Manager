using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTimeManager
{
    public partial class LoginUc : UserControl
    {
        public event EventHandler<UserEventArgs> LoginSuccess;
        public event EventHandler<EventArgs> RegisterClick;

        public LoginUc()
        {
            InitializeComponent();
        }

        private static async Task<User> GetUserAsync(string name, string password)
        {
            User user = null;

            try
            {
                using (var dbContext = new DbContext())
                {
                    var userId = await dbContext.Users
                        .Where(u => u.Name == name && u.Password == password)
                        .Select(u => u.Id)
                        .FirstAsync();

                    user = await dbContext.Users.FindAsync(userId);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("User name or password is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return user;
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = await GetUserAsync(nameBox.Text, passwordBox.Text);

            if (user != null)   // User exists
            {
                LoginSuccess?.Invoke(sender, new UserEventArgs { User = user });
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterClick?.Invoke(sender, EventArgs.Empty);
        }
    }
}
