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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }


        private void formSettings_Load(object sender, EventArgs e)
        {
            textBoxInputPath.Text = Properties.Settings.Default.DocumentsInputPath;
            textBoxOutputPath.Text = Properties.Settings.Default.DocumentsOutputPath;
        }

        private void buttonChangeInputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInputPath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.DocumentsInputPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonChangeOutputPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputPath.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.DocumentsOutputPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
