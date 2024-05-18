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

        private void CreateColumns()
        {
            dataGridViewCartriges.Columns.Add("model", "Модель");
            dataGridViewCartriges.Columns.Add("barcode", "Штрихкод");
            dataGridViewCartriges.Columns.Add("direction", "Направление");
        }

        private void AddCartigeToRegister(string barcode)
        {
            string queryGetString = $"SELECT model, barcode FROM Technics WHERE barcode = '{barcode}' \r\nSELECT model, barcode FROM Сartridges WHERE barcode = '{barcode}' ";
            SqlCommand getCommand = new SqlCommand(queryGetString, dataBase.getSqlConnection());

            dataBase.openConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable manualDTable = new DataTable();
            adapter.SelectCommand = getCommand;
            adapter.Fill(manualDTable);


            for (int i = 0; i < manualDTable.Rows.Count; i++)
            {
                dataGridViewCartriges.Rows.Add(manualDTable.Rows[i][0], barcode, directionText());

                string querySetString = $"INSERT INTO Register (barcode, direction, movementDate) VALUES ('{barcode}','{directionText()}','{DateTime.Now}')"
                                      + $"UPDATE Сartridges SET onRepair = '{checkBoxDirectionOut.Checked}', modifiedDate = '{DateTime.Now}' WHERE barcode = '{barcode}'\r\nUPDATE Technics SET onRepair = '{checkBoxDirectionOut.Checked}', modifiedDate = '{DateTime.Now}' WHERE barcode = '{barcode}'";               
                SqlCommand setCommand = new SqlCommand(querySetString, dataBase.getSqlConnection());
                setCommand.ExecuteNonQuery();
            }
            
            dataBase.closeConnection();


            if (manualDTable.Rows.Count == 0 && Application.OpenForms["formAddCartrige"] == null && MessageBox.Show($"Код: {barcode} \nШтрихкод не найден, добавить новую запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormRegistrationElement formAddCartrige = new FormRegistrationElement(barcode);
                formAddCartrige.Show();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (!FindDGVDublicate(textBoxEnterBarcode.Text, dataGridViewCartriges))
                    AddCartigeToRegister(textBoxEnterBarcode.Text);
            else
                MessageBox.Show("Запись уже существует");
            textBoxEnterBarcode.Text = string.Empty;
        }

        private bool FindDGVDublicate(string barcode, DataGridView dataGrid) //Поиск в колонке повторяющегося значения
        {
            bool dublicate = false;

            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                if (dataGrid.Rows[i].Cells[1].Value.ToString() == textBoxEnterBarcode.Text)
                {
                    dublicate = true;
                }
            }
            return dublicate;
        }

        private void formCartriges_Load(object sender, EventArgs e)
        {
            CreateColumns();
            //dataGridViewCartriges.Columns[0].Width = 100;
            //dataGridViewCartriges.Columns[3].Width = 200;

            textBoxEnterBarcode.Focus();
        }

        private void textBoxEnterBarcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter_Click(sender, e);
            }
        }


        private void checkBoxDirectionIn_Click(object sender, EventArgs e)
        {
            checkBoxDirectionIn.Checked = true;
            checkBoxDirectionIn.ForeColor = default;
            checkBoxDirectionOut.Checked = !checkBoxDirectionIn.Checked;
            checkBoxDirectionOut.ForeColor = Color.Silver;
            textBoxEnterBarcode.Focus();
        }
        private void checkBoxDirectionOut_Click(object sender, EventArgs e)
        {
            checkBoxDirectionOut.Checked = true;
            checkBoxDirectionOut.ForeColor = default;
            checkBoxDirectionIn.Checked = !checkBoxDirectionOut.Checked;
            checkBoxDirectionIn.ForeColor = Color.Silver;
            textBoxEnterBarcode.Focus();
        }


        private string directionText()
        {
            if (checkBoxDirectionOut.Checked)
                return (checkBoxDirectionIn.Text);
            else return (checkBoxDirectionOut.Text);
        }

    }
}
