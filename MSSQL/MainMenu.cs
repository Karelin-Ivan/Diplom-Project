using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL
{

    public partial class formMainMenu : Form
    {
        private readonly checkUser _user;

        public formMainMenu(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void isAdmin()
        {
            toolStripButtonUsers.Visible = _user.IsAdmin;
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            isAdmin();
            toolStripLabelUserStatus.Text = $"{_user.Login}: {_user.Status}";
        }

        private void toolStripButtonUsers_Click(object sender, EventArgs e)
        {
            formAdminisrtationUsers adminisrtationUsers = new formAdminisrtationUsers();
            if (Application.OpenForms["AdminisrtationUsers"] == null)
                adminisrtationUsers.Show();
        }

        private void formMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
