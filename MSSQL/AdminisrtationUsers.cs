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
    public partial class formAdminisrtationUsers : Form
    {
        DataBase dataBase = new DataBase();

        public formAdminisrtationUsers()
        {
            InitializeComponent();
        }

        private void AdminisrtationUsers_Load(object sender, EventArgs e)
        {

            CreateColumns();
            RefreshDataGrid(dataGridViewUsers);
        }

        private void CreateColumns()
        {
            dataGridViewUsers.Columns.Add("id", "id");
            dataGridViewUsers.Columns.Add("username", "Имя пользователя");
            dataGridViewUsers.Columns.Add("login", "Логин");
            var checkAdmin = new DataGridViewCheckBoxColumn();
            checkAdmin.HeaderText = "roleAdmin";
            dataGridViewUsers.Columns.Add(checkAdmin);
            var checkActive = new DataGridViewCheckBoxColumn();
            checkActive.HeaderText = "Active";
            dataGridViewUsers.Columns.Add(checkActive);
            dataGridViewUsers.Columns.Add("IsNew", string.Empty);

            dataGridViewUsers.Columns[0].ReadOnly = true;
            dataGridViewUsers.Columns[1].ReadOnly = true;
            dataGridViewUsers.Columns[2].ReadOnly = true;
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt16(0), record.GetString(1), record.GetString(2), record.GetBoolean(4), record.GetBoolean(5));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Users";

            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();
        }


        private void buttonDeleteElement_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var selectedRowIndex = dataGridViewUsers.CurrentCell.RowIndex;

            var id = Convert.ToInt16(dataGridViewUsers.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"DELETE FROM Users WHERE id = {id}";

            var command = new SqlCommand(deleteQuery, dataBase.getSqlConnection());
            command.ExecuteNonQuery();
            RefreshDataGrid (dataGridViewUsers);
        }

        private void AdminisrtationUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataBase.openConnection();

            for (int i = 0; i < dataGridViewUsers.Rows.Count; i++)
            {
                var id = dataGridViewUsers.Rows[i].Cells[0].Value.ToString();
                var isAdmin = dataGridViewUsers.Rows[i].Cells[3].Value.ToString();
                var isActive = dataGridViewUsers.Rows[i].Cells[4].Value.ToString();

                var changeQuery = $"UPDATE Users SET roleAdmin = '{isAdmin}', active = '{isActive}' WHERE id = '{id}'";

                var command = new SqlCommand(changeQuery, dataBase.getSqlConnection());
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();

            RefreshDataGrid(dataGridViewUsers);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Registration"] == null)
            {
                formRegistration formRegistration = new formRegistration();
                formRegistration.Location = this.Location;
                formRegistration.Show();
            }
        }
    }
}
