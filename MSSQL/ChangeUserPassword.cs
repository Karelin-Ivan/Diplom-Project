using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL
{
    public partial class FormChangeUserPassword : Form
    {
        DataBase dataBase = new DataBase();
        Int16 userID;

        public FormChangeUserPassword(Int16 id)
        {
            InitializeComponent();
            userID = id;
        }

        private void ChangeUserPassword_Load(object sender, EventArgs e)
        {
            textBoxPasswordConfirm.PasswordChar = '*';
            textBoxPasswordConfirm.MaxLength = 10;
            textBoxNewPassword.MaxLength = 10;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != string.Empty && textBoxPasswordConfirm.Text == textBoxNewPassword.Text)
            {
                string hashPass = HashFunction.HashPassword(textBoxNewPassword.Text);
                string queryString = $"UPDATE Users SET pass = '{hashPass}' WHERE id = '{userID}'";
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
                MessageBox.Show("Ошибка заполнения полей!");
        }
    }
}
