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
    public partial class FormRegistrationTechnic : Form
    {
        DataBase dataBase = new DataBase();
        public FormRegistrationTechnic(string barcode)
        {
            InitializeComponent();
            textBoxBarcode.Text = barcode;

            foreach (string el in DataBaseCommands.GetUniqueItems("Technics"))
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
                string queryString = $"INSERT INTO Technics (barcode, inventoryNumber ,model, [owner], organization, modifiedDate, placement, onRepair) VALUES ({textBoxBarcode.Text},{textBoxInventoryNumber.Text},{comboBoxModel.Text},{textBoxMOL.Text},{comboBoxOrganization.Text},{DateTime.Now},{textBoxPlacement.Text},{false})";
                SqlCommand command = new SqlCommand(queryString, dataBase.getSqlConnection());
                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Ошибка соединения", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataBase.closeConnection();


                //Закрытие общей формы
                Application.OpenForms.OfType<Form>()
                                     .Where(form => String.Equals(form.Name, "FormRegistrationElement"))
                                     .ToList()
                                     .ForEach(form => form.Close());

            }
            else
                MessageBox.Show("Заполните все поля с знаком '*'!");
        }

        private void buttonChanngeStyle_Click(object sender, EventArgs e)
        {
            if (comboBoxModel.DropDownStyle == ComboBoxStyle.DropDownList)
                comboBoxModel.DropDownStyle = ComboBoxStyle.DropDown;
            else
                comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
