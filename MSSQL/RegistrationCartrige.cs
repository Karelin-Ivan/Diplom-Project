using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MSSQL
{
    public partial class FormRegCartrige : Form
    {
        DataBase dataBase = new DataBase();
        public FormRegCartrige(string barcode)
        {
            InitializeComponent();
            textBoxBarcode.Text = barcode;
        }

        private void formAddCartrige_Load(object sender, EventArgs e)
        {
            foreach (string el in DataBaseCommands.GetUniqueItems("Сartridges"))
            {
                comboBoxModel.Items.Add(el);
            }

            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.MaxLength = 32;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text != string.Empty && comboBoxOrganization.Text != string.Empty && comboBoxModel.Text != string.Empty)
            {
                string queryString = $"INSERT INTO Cartridges (model, barcode, organization) VALUES ('{comboBoxModel.Text}', '{textBoxBarcode.Text}','{comboBoxOrganization.Text}')";
                SqlCommand command = new SqlCommand(queryString, dataBase.getSqlConnection());
                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка соединения", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataBase.closeConnection();
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void buttonChanngeStyle_Click(object sender, EventArgs e)
        {
            if(comboBoxModel.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBoxModel.DropDownStyle = ComboBoxStyle.DropDown;
            else
                comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}
