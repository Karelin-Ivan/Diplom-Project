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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;

namespace MSSQL
{
    public partial class formCartriges : Form
    {
        public formCartriges()
        {
            InitializeComponent();
        }

        DataBase dataBase = new DataBase();

        private void checkBoxDirection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDirection.Checked)
            {
                checkBoxDirection.Text = "Прием картриджей";
                checkBoxDirection.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                checkBoxDirection.Text = "Отпуск картриджей";
                checkBoxDirection.BackColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Обработчик на нажатие
            }
        }

        private void addCartigeToRegister(string barcode, string direction)
        {
            string queryGetString = $"select id, model, barcode, onRepair, organization, modifiedDate from СartridgesGuide where (barcode = '{barcode}')";

            SqlCommand getCommand = new SqlCommand(queryGetString, dataBase.getSqlConnection());

            dataBase.openConnection();


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dtable = new DataTable();
            adapter.SelectCommand = getCommand;
            adapter.Fill(dtable);
            if (dtable.Rows.Count == 1)
            {

                SqlDataReader dataReader = getCommand.ExecuteReader(); //Убрать ридер и получать значения и datatable которую ранее заполнили

                bool onRepair = false;
                while (dataReader.Read())
                {
                    textBoxId.Text = dataReader.GetValue(0).ToString();
                    textBoxName.Text = dataReader.GetValue(1).ToString();
                    textBoxBarcode.Text = dataReader.GetValue(2).ToString();
                    textBoxOnRepair.Text = dataReader.GetValue(3).ToString();
                    onRepair = dataReader.GetBoolean(3);
                    textBoxOrganization.Text = dataReader.GetValue(4).ToString();
                    textBoxModDate.Text = dataReader.GetValue(5).ToString();

                }
                dataReader.Close();


                string querySetString = $"INSERT INTO СartridgesRegister (model, barcode, direction, organization, date) VALUES ('{textBoxName.Text}', '{textBoxBarcode.Text}','{direction}','{textBoxOrganization.Text}', '{DateTime.Now}')"
                                      + $"UPDATE СartridgesGuide SET onRepair = '{!onRepair}', modifiedDate = '{DateTime.Now}'";

                SqlCommand setCommand = new SqlCommand(querySetString, dataBase.getSqlConnection());
                setCommand.ExecuteNonQuery();

            }
            else if (dtable.Rows.Count == 0 &&  Application.OpenForms["formAddCartrige"] == null && MessageBox.Show($"Код: {barcode} /nКартридж не найден, добавить новую запись в базу?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formAddCartrige formAddCartrige = new formAddCartrige(barcode);
                formAddCartrige.Show();
            }
            dataBase.closeConnection();

        

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            addCartigeToRegister(textBoxEnterBarcode.Text, checkBoxDirection.Text);
            textBoxEnterBarcode.Text = string.Empty;
        }


    }


        /*
        private void CreateColumns()
        {
            dataGridViewCartriges.Columns.Add("id", "id");
            dataGridViewCartriges.Columns.Add("username", "Имя пользователя");
            dataGridViewCartriges.Columns.Add("login", "Логин");
            var checkAdmin = new DataGridViewCheckBoxColumn();
            checkAdmin.HeaderText = "roleAdmin";
            dataGridViewCartriges.Columns.Add(checkAdmin);
            var checkActive = new DataGridViewCheckBoxColumn();
            checkActive.HeaderText = "active";
            dataGridViewCartriges.Columns.Add(checkActive);
            dataGridViewCartriges.Columns.Add("registrationDate", "Дата изменения");


            dataGridViewCartriges.Columns[0].ReadOnly = true;
            dataGridViewCartriges.Columns[1].ReadOnly = true;
            dataGridViewCartriges.Columns[2].ReadOnly = true;
            dataGridViewCartriges.Columns[5].ReadOnly = true;

        }

        public void RefreshDataGrid(DataGridView dgw)
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

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt16(0), record.GetString(1), record.GetString(2), record.GetBoolean(4), record.GetBoolean(5), record.GetDateTime(6));
        }

        */

    
}
