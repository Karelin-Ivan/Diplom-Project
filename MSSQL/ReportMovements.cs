using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MSSQL
{
    public partial class FormReport : Form
    {
        DataBase dataBase = new DataBase();
        bool EnableCartridges = true;
        bool EnableTehnics = true;
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
            RefreshDataGrid(dataGridViewReport, QueryString());
        }

        private void RefreshDataGrid(DataGridView dgw,string queryString)
        {
            dgw.Rows.Clear();

            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());
            dataBase.openConnection();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();
        }
        private string QueryString()
        {

            StringBuilder myStringBuilder = new StringBuilder("SELECT model, Register.barcode, direction, organization, movementDate FROM Register INNER JOIN ");
            if (EnableCartridges && !EnableTehnics)
            {
                myStringBuilder.Append($"Сartridges ON(Register.Barcode = Сartridges.barcode) ");
                myStringBuilder.Append(QueryStringAddition());
                myStringBuilder.Append(" ORDER BY movementDate");
            }
            else if (!EnableCartridges && EnableTehnics)
            {
                myStringBuilder.Append($"Technics ON(Register.Barcode = Technics.barcode) ");
                myStringBuilder.Append(QueryStringAddition());
                myStringBuilder.Append(" ORDER BY movementDate");
            }
            else
            {
                myStringBuilder.Append($"Сartridges ON (Register.Barcode = Сartridges.barcode) ");
                myStringBuilder.Append(QueryStringAddition());
                myStringBuilder.Append("UNION SELECT model, Register.barcode, direction, organization, movementDate " +
                                       $"FROM Register INNER JOIN Technics ON (Register.Barcode = Technics.barcode) ");
                myStringBuilder.Append(QueryStringAddition());
                myStringBuilder.Append(" ORDER BY movementDate");
            }


            return myStringBuilder.ToString();
        }
        private string QueryStringAddition()
        {
            StringBuilder myStringBuilder = new StringBuilder($"WHERE movementDate > '{dateTimePickerStart.Value}' AND movementDate < '{dateTimePickerEnd.Value}'");
            if (textBoxBarcode.Text != string.Empty)
                myStringBuilder.Append(" AND Register.barcode = '" + textBoxBarcode.Text + "'");
            if (comboBoxModel.Text != string.Empty)
                myStringBuilder.Append(" AND model = '" + comboBoxModel.Text + "'");
            if (comboBoxDirection.Text != string.Empty)
                myStringBuilder.Append(" AND direction = '" + comboBoxDirection.Text + "'");
            if (comboBoxOrganization.Text != string.Empty)
                myStringBuilder.Append(" AND organization = '" + comboBoxOrganization.Text + "'");
            return (myStringBuilder.ToString());
        }


        private void CreateColumns()
        {
            dataGridViewReport.Columns.Add("model", "Модель");
            dataGridViewReport.Columns.Add("barcode", "Штрихкод");
            dataGridViewReport.Columns.Add("direction", "Направление");
            dataGridViewReport.Columns.Add("organization", "Организация");
            dataGridViewReport.Columns.Add("movementDate", "Дата движения");
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add( record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4));
        }

        private void buttonTechnics_Click(object sender, EventArgs e)
        {
            if(EnableTehnics)
            {
                buttonTechnics.ForeColor = Color.Silver;
                EnableTehnics = false;
            }
                
            else
            {
                buttonTechnics.ForeColor = default;
                EnableTehnics = true;
            }
        }

        private void buttonCartriges_Click(object sender, EventArgs e)
        {
            if(EnableCartridges)
            {
                buttonCartriges.ForeColor = Color.Silver;
                EnableCartridges = false;
            }
            else
            {
                buttonCartriges.ForeColor = default; EnableCartridges = true;
                EnableCartridges = true;
            } 
        }
    }
}
