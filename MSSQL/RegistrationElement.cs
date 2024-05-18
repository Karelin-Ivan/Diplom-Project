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
    public partial class FormRegistrationElement : Form
    {
        private new Form ActiveForm;
        private string barcode;
        public FormRegistrationElement(string barcode)
        {
            InitializeComponent();
            this.barcode = barcode;
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

        private void buttonTechnics_Click(object sender, EventArgs e)
        {
            buttonTechnics.ForeColor = default;
            buttonCartrige.ForeColor = Color.Silver;
            OpenChildForm(new FormRegistrationTechnic(barcode));
            this.Size = new System.Drawing.Size(370, 580);
            panelFormLoader.Size = new System.Drawing.Size(350, 440);
        }

        private void buttonCartrige_Click(object sender, EventArgs e)
        {
            buttonTechnics.ForeColor = Color.Silver;
            buttonCartrige.ForeColor = default;
            OpenChildForm(new FormRegCartrige(barcode));
            this.Size = new System.Drawing.Size(370, 390);
            panelFormLoader.Size = new System.Drawing.Size(350, 250);
        }

        private void FormRegistrationElement_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormRegCartrige(barcode)); 
        }
    }
}
