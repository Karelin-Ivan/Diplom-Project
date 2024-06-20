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
    public partial class FormAuthorization : Form
    {
        DataBase dataBase = new DataBase();

        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void MSSQL_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 10;
            textBoxLogin.MaxLength = 10;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLogin.Text;
            var passUser = HashFunction.HashPassword(textBoxPassword.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtable = new DataTable();

            string querystring = $"select * from Users where login = '{loginUser}' and  pass = '{passUser}'and active='true'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getSqlConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dtable);
            if (dtable.Rows.Count == 1)
            {
                checkUser user = new checkUser(dtable.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(dtable.Rows[0].ItemArray[4]));
                
                FormMainMenu mainExample = new FormMainMenu(user);
                mainExample.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User unfound", null, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) 
            {
                buttonLogin_Click(sender,e);
            }
        }
    }
}
