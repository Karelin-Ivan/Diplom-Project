using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace MSSQL
{
    public partial class FormRegistration : Form
    {

        DataBase dataBase = new DataBase();
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text;
            var login = textBoxLogin.Text;
            var password = HashFunction.HashPassword(textBoxPassword.Text);
            bool roleAdmin = checkBoxRoleAdmin.Checked;
            bool userActive = checkBoxUserActive.Checked;


            string querystring = $"INSERT INTO Users (username, login, pass, roleAdmin,active) VALUES ('{username}','{login}','{password}','{roleAdmin}','{userActive}')";

            if ( checkPasswordSimilar() && checkFillings() && checkUser())
            {
                SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());
                dataBase.openConnection();
                if(command.ExecuteNonQuery() ==1)//Проверка выполнилась ли команда
                {
                    MessageBox.Show("Аккаунт успешно создан");
                    this.Close();     
                }
                else
                    MessageBox.Show("Ошибка соединения",null,MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataBase.closeConnection();
            }
        }

        private Boolean checkPasswordSimilar()
        {
            if(textBoxPassword.Text == textBoxPasswordConfirm.Text)
                return true;
            else
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка");
                return false;
            }
            
        }

        private Boolean checkFillings() //Проверка заполнености полей
        {
            if (String.IsNullOrWhiteSpace(textBoxUsername.Text)|| String.IsNullOrWhiteSpace(textBoxLogin.Text)||String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все обязательнве поля");
                return false;
            }
            else
                return true;
        }


        private Boolean checkUser() //Проверка на существование пользователя
        {
            var login = textBoxLogin.Text;
            var username = textBoxUsername.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string queryString = $"select * from Users where (login = '{login}' or username = '{username}')";
            SqlCommand cmd = new SqlCommand(queryString, dataBase.getSqlConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Данный аккаунт уже существует!");
                return false;
            }
            else
                return true;
        }

    }
}
