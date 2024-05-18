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
    public partial class FormReport : Form
    {
        DataBase dataBase = new DataBase();

        public FormReport()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Now.Date;
            dateTimePickerEnd.Value = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59);

            foreach (string el in DataBaseCommands.GetUniqueItems("Сartridges"))
            {
                comboBoxModel.Items.Add(el);
            }

            CreateColumns();
        }

        private void buttoConfirm_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewReport);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM СartridgesRegister WHERE movementDate > '{dateTimePickerStart.Value}' AND movementDate < '{dateTimePickerEnd.Value}'";
            SqlCommand comand = new SqlCommand(AddElToQueryString(queryString), dataBase.getSqlConnection());
            dataBase.openConnection();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();
        }

        private string AddElToQueryString(string queryString)
        {
            if (textBoxBarcode.Text != string.Empty)
                queryString += " AND barcode = '" + textBoxBarcode.Text + "'";
            if (comboBoxModel.Text != string.Empty)
                queryString += " AND model = '" + comboBoxModel.Text + "'";
            if (comboBoxDirection.Text != string.Empty)
                queryString += " AND direction = '" + comboBoxDirection.Text + "'";
            if (comboBoxOrganization.Text != string.Empty)
                queryString += " AND organization = '" + comboBoxOrganization.Text + "'";

            return queryString;
        }


        private void CreateColumns()
        {
            dataGridViewReport.Columns.Add("id", "id");
            dataGridViewReport.Columns.Add("model", "Модель");
            dataGridViewReport.Columns.Add("barcode", "Штрихкод");
            dataGridViewReport.Columns.Add("direction", "Направление");
            dataGridViewReport.Columns.Add("organization", "Организация");
            dataGridViewReport.Columns.Add("movementDate", "Дата движения");
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetDateTime(5));
        }

    }
}
