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

    public partial class FormMainMenu : Form
    {
        private readonly checkUser _user;
        private new Form ActiveForm;

        public FormMainMenu(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }

        private void isAdmin()
        {
            toolStripButtonSetting.Visible = _user.IsAdmin;
            toolStripButtonRepair.Visible = _user.IsAdmin;
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            isAdmin();
            toolStripLabelUserStatus.Text = $"{_user.Login}: {_user.Status}";

            OpenChildForm(new FormStatistics());
        }

        private void сканерToolStripMenuItem_Click(object sender, EventArgs e)
        {
                OpenChildForm(new FormCartriges());
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
                ActiveForm.Dispose();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormLoader.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();  
        }

        private void toolStripButtonSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSettings());
        }

        private void toolStripButtonRepair_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCreatePDF());
        }

        private void toolStripButtonUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdminisrtationUsers());
        }

        private void toolStripLabelUserStatus_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["formAuthorization"] == null)
            {
                FormAuthorization formAuthorization = new FormAuthorization();
                formAuthorization.Show();
            }
        }

        private void toolStripMenuItemReportRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReport());
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms.OfType<Form>()
                                     .ToList()
                                     .ForEach(form => form.Close());
            //Application.Exit();
        }

        private void toolStripButtonStatistics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStatistics());
        }
    }
}
