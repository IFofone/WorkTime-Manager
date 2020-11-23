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
    public partial class RegisterUc : UserControl
    {
        public event EventHandler<EventArgs> LoginClick;
        public event EventHandler<EventArgs> RegisterSuccess;

        public RegisterUc()
        {
            InitializeComponent();
        }

        private static async Task CreateNewUserAsync(string name, string password)
        {
            using (var dbContext = new DbContext())
            {
                var newUser = new User { Name = name, Password = password };

                dbContext.Users.Add(newUser);

                await dbContext.SaveChangesAsync();
            }
        }

        private static async Task<bool> CheckNameUniqueAsync(string name)
        {
            using (var dbContext = new DbContext())
            {
                var usersList = await dbContext.Users
                    .Where(u => u.Name == name)
                    .ToListAsync();

                return !usersList.Any();
            }
        }

        private static bool CheckPasswordsMatch(string password, string passwordRpt)
        {
            return password.Equals(passwordRpt);
        }

        private async void RegisterBtn_Click(object sender, EventArgs e)
        {
            var passwordsMatch = CheckPasswordsMatch(passwordBox.Text, passwordRptBox.Text);
            var isNameUnique = await CheckNameUniqueAsync(nameBox.Text);

            var errorMessage = new StringBuilder();

            if (nameBox.Text == string.Empty || passwordBox.Text == string.Empty)
            {
                errorMessage.Append("Field cannot be empty!\n");
            }

            if (!isNameUnique)
            {
                errorMessage.Append("Name already taken!\n");
                nameBox.Text = string.Empty;
            }

            if (!passwordsMatch)
            {
                errorMessage.Append("Passwords do not match!\n");
                passwordBox.Text = string.Empty;
                passwordRptBox.Text = string.Empty;
            }

            if (errorMessage.Length == 0)
            {
                await CreateNewUserAsync(nameBox.Text, passwordBox.Text);
                MessageBox.Show("Registration successful!\nYou can log in now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RegisterSuccess?.Invoke(sender, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(errorMessage.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginClick?.Invoke(sender, EventArgs.Empty);
        }
    }
}
