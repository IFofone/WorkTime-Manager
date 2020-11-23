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
    public partial class AccountInfoUc : UserControl
    {
        public event EventHandler<EventArgs> Logout;

        private readonly User _user;

        public AccountInfoUc(User user)
        {
            InitializeComponent();

            _user = user;
            nameLabel.Text = _user.Name;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Logout?.Invoke(sender, EventArgs.Empty);
            MessageBox.Show("You have been logged out!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
