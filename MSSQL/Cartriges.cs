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
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MSSQL
{
    public partial class FormCartriges : Form
    {
        public FormCartriges()
        {
            InitializeComponent();
        }

        DataBase dataBase = new DataBase();

        private void checkBoxDirection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDirection.Checked)
            {
                checkBoxDirection.Text = "Прием картриджей";
            }
            else
            {
                checkBoxDirection.Text = "Отпуск картриджей";
            }
        }
        private void CreateColumns()
        {
            dataGridViewCartriges.Columns.Add("id", "id");
            dataGridViewCartriges.Columns.Add("model", "Модель");
            dataGridViewCartriges.Columns.Add("barcode", "Штрихкод");
            dataGridViewCartriges.Columns.Add("onRepair", "На ремонте");
            dataGridViewCartriges.Columns.Add("organization", "Организация");
            dataGridViewCartriges.Columns.Add("modifiedDate", "Дата последнего изменения");

        }



        private void AddCartigeToRegister(string barcode, string direction)
        {
            string queryGetString = $"select id, model, barcode, onRepair, organization, modifiedDate from Сartridges";

            SqlCommand getCommand = new SqlCommand(queryGetString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable manualDTable = new DataTable();
            adapter.SelectCommand = getCommand;
            adapter.Fill(manualDTable);

            bool noHits = false;

            for (int i = 0; i < manualDTable.Rows.Count; i++)
            {
                if (manualDTable.Rows[i][2].ToString() == textBoxEnterBarcode.Text)
                {
                    dataGridViewCartriges.Rows.Add(manualDTable.Rows[i][0], manualDTable.Rows[i][1], manualDTable.Rows[i][2], manualDTable.Rows[i][3], manualDTable.Rows[i][4], manualDTable.Rows[i][5]);

                    string querySetString = $"INSERT INTO СartridgesRegister (model, barcode, direction, organization, movementDate) VALUES ('{manualDTable.Rows[i][1]}', '{manualDTable.Rows[i][2]}','{direction}','{manualDTable.Rows[i][4]}', '{DateTime.Now}')"
                                          + $"UPDATE Сartridges SET onRepair = '{!checkBoxDirection.Checked}', modifiedDate = '{DateTime.Now}' WHERE id = '{manualDTable.Rows[i][0]}'";

                    SqlCommand setCommand = new SqlCommand(querySetString, dataBase.getSqlConnection());
                    setCommand.ExecuteNonQuery();
                    dataBase.closeConnection();
                    noHits = true;
                }
            }
            if(!noHits && Application.OpenForms["formAddCartrige"] == null && MessageBox.Show($"Код: {barcode} \nКартридж не найден, добавить новую запись в базу?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormRegCartrige formAddCartrige = new FormRegCartrige(barcode);
                formAddCartrige.Show();
            }

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (!FindDGVDublicate(textBoxEnterBarcode.Text, dataGridViewCartriges))
            {
                AddCartigeToRegister(textBoxEnterBarcode.Text, checkBoxDirection.Text);
            }
            else
                MessageBox.Show("Картидж уже добавлен");
            textBoxEnterBarcode.Text = string.Empty;
        }

        private bool FindDGVDublicate(string barcode, DataGridView dataGrid) //Поиск в колонке повторяющегося значения
        {
            bool dublicate = false;

            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                if (dataGrid.Rows[i].Cells[2].Value.ToString() == textBoxEnterBarcode.Text)
                {
                    dublicate = true;
                }
            }
            return dublicate;
        }

        private void formCartriges_Load(object sender, EventArgs e)
        {
            CreateColumns();
            dataGridViewCartriges.Columns[0].Width = 100;
            dataGridViewCartriges.Columns[3].Width = 200;

            textBoxEnterBarcode.Focus();
        }

        private void textBoxEnterBarcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter_Click(sender, e);
            }
        }
    }
}
