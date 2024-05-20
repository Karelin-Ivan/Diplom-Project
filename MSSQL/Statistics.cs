using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace MSSQL
{
    public partial class FormStatistics : Form
    {
        DataBase dataBase = new DataBase();

        public FormStatistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            CreateChart();
            CreateColumns();
            RefreshDataGrid(dataGridView, "Сartridges");
            buttonCartrigesOnRepair.Text = RefreshDataButtons("Сartridges");
            buttonTechnicsOnRepair.Text = RefreshDataButtons("Technics");
        }

        private void CreateChart() //ЧАРТ СОБИРАЕТСЯ ПО ВСЕМ ДАННЫМ ПЕРЕПИСАТЬ НА JOIN
        {
            Series series = chartOnRepair.Series.Add("");
            for (int i = -6; i <= 0; i++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.AddMonths(i).Month);
                int countPoint = 0;

                DateTime startMonth = DateTime.Today.AddDays(-(DateTime.Now.Day - 1));
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                string queryString = $"SELECT COUNT(*) FROM Register WHERE movementDate > '{startMonth.AddMonths(i)}' AND movementDate < '{startMonth.AddMonths(i).AddDays(daysInMonth)}' AND direction = 'Отпуск'";
                using (SqlCommand cmd = new SqlCommand(queryString, dataBase.getSqlConnection()))
                {
                    dataBase.openConnection();
                    countPoint = (int)cmd.ExecuteScalar();
                    dataBase.closeConnection();
                }
                series.Points.AddXY(monthName, countPoint);
            }
        }

        private void RefreshDataGrid(DataGridView dgw, string DBName)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT model,barcode FROM {DBName} WHERE  onRepair = 1 ORDER BY model";
            //Добавить в строку запроса для получения данных только за данный месяц
            //modifiedDate > '{DateTime.Now.AddDays(-(DateTime.Now.Day - 1))}' AND modifiedDate < '{DateTime.Now}' AND
            SqlCommand comand = new SqlCommand(queryString, dataBase.getSqlConnection());
            dataBase.openConnection();
            SqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                ReadSinglRow(dgw, reader);
            }
            reader.Close();

        }

        private string RefreshDataButtons(string DBName)
        {
            string queryString = $"SELECT COUNT (*) FROM {DBName} WHERE onRepair = 1";
            using (SqlCommand cmd = new SqlCommand(queryString, dataBase.getSqlConnection()))
            {
                dataBase.openConnection();
                string str = cmd.ExecuteScalar().ToString();
                dataBase.closeConnection();
                return (str);
                
            }
        }

        private void CreateColumns()
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("model", "Модель");
            dataGridView.Columns.Add("barcode", "Штрихкод");
        }

        private void ReadSinglRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add( record.GetString(0), record.GetString(1));
        }

        private void buttonCartrigesOnRepair_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView, "Сartridges");
        }

        private void buttonTechnicsOnRepair_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView, "Technics");
        }

    }
}
