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
        bool toRepair=false;

        private void CreateColumns()
        {
            dataGridViewCartriges.Columns.Add("barcode", "Штрихкод");
            dataGridViewCartriges.Columns.Add("model", "Модель");
            dataGridViewCartriges.Columns.Add("direction", "Направление");
        }

        private void AddCartigeToRegister(string barcode)
        {
            string querystringCount = $"SELECT SUM(Count) AS TotalCount FROM (SELECT COUNT(*) AS Count FROM Сartridges where barcode = '{barcode}'UNION ALL SELECT COUNT(*) FROM Technics where barcode = '{barcode}') AS SubQuery;";

            SqlCommand commandCount = new SqlCommand(querystringCount, dataBase.getSqlConnection());

            dataBase.openConnection();
            if ((int)commandCount.ExecuteScalar() == 1 && !DGVHaveDublicate(barcode, dataGridViewCartriges))
            {
                string queryGetString = $"(SELECT barcode, model FROM Сartridges WHERE barcode ='{barcode}') UNION (SELECT barcode, model FROM Technics WHERE barcode ='{barcode}') ";
                SqlCommand getCommand = new SqlCommand(queryGetString, dataBase.getSqlConnection());

                SqlDataReader reader = getCommand.ExecuteReader();
                while (reader.Read())
                {
                    dataGridViewCartriges.Rows.Add(reader.GetString(0), reader.GetString(1), directionText());
                }
                reader.Close();

                string querySetString = $"INSERT INTO Register (barcode, direction, movementDate) VALUES ('{barcode}','{directionText()}','{DateTime.Now}')"
                                      + $"UPDATE Сartridges SET onRepair = '{toRepair}', modifiedDate = '{DateTime.Now}' WHERE barcode = '{barcode}'\r\nUPDATE Technics SET onRepair = '{toRepair}', modifiedDate = '{DateTime.Now}' WHERE barcode = '{barcode}'";
                SqlCommand setCommand = new SqlCommand(querySetString, dataBase.getSqlConnection());
                setCommand.ExecuteNonQuery();

            }
            else if (DGVHaveDublicate(barcode, dataGridViewCartriges))
                MessageBox.Show("Запись с таким штрихкодом уже добавлена!");
            else if (Application.OpenForms["formAddCartrige"] == null && MessageBox.Show($"Штрихкод {barcode} не найден, добавить новую запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FormRegistrationElement formAddCartrige = new FormRegistrationElement(barcode);
                formAddCartrige.Show();
            }
            dataBase.closeConnection();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            AddCartigeToRegister(textBoxEnterBarcode.Text);
            textBoxEnterBarcode.Text = string.Empty;
            textBoxEnterBarcode.Focus();
        }

        private bool DGVHaveDublicate(string barcode, DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                if (dataGrid.Rows[i].Cells[0].Value.ToString() == barcode)
                {
                   return(true);
                }
            }
            return (false);
        }

        private void formCartriges_Load(object sender, EventArgs e)
        {
            CreateColumns();
            textBoxEnterBarcode.Focus();
        }

        private void textBoxEnterBarcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter_Click(sender, e);
            }
        }


        private string directionText()
        {
            if (toRepair)
                return (buttonOUT.Text);
            else return (buttonIN.Text);
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            toRepair = false;
            buttonIN.ForeColor = default;
            buttonOUT.ForeColor = Color.Silver;
            textBoxEnterBarcode.Focus();
        }

        private void buttonOUT_Click(object sender, EventArgs e)
        {
            toRepair = true;
            buttonOUT.ForeColor = default;
            buttonIN.ForeColor = Color.Silver;
            textBoxEnterBarcode.Focus();
        }

    }
}
