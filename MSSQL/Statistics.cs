﻿using System;
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
            RefreshDataGrid(dataGridView);
        }

        private void CreateChart()
        {
            Series series = chartOnRepair.Series.Add("");
            for (int i = -6; i <= 0; i++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.AddMonths(i).Month);
                int countPoint = 0;

                DateTime startMonth = DateTime.Today.AddDays(-(DateTime.Now.Day - 1));
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                string queryString = $"SELECT COUNT(*) FROM СartridgesRegister WHERE movementDate > '{startMonth.AddMonths(i)}' AND movementDate < '{startMonth.AddMonths(i).AddDays(daysInMonth)}' AND direction = 'Отпуск картриджей'";
                using (SqlCommand cmd = new SqlCommand(queryString, dataBase.getSqlConnection()))
                {
                    dataBase.openConnection();
                    countPoint = (int)cmd.ExecuteScalar();
                    dataBase.closeConnection();
                }
                series.Points.AddXY(monthName, countPoint);
            }
            Series series1 = chartOnRepair.Series.Add("");
            double[] nfg = { 10, 11 };
            series1.Points.DataBindY(nfg);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Сartridges WHERE  onRepair = 1 ORDER BY model";
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

            RefreshDataButtons();
        }

        private void RefreshDataButtons()
        {
            string queryString = $"SELECT COUNT (*) FROM Сartridges WHERE onRepair = 1";
            using (SqlCommand cmd = new SqlCommand(queryString, dataBase.getSqlConnection()))
            {
                dataBase.openConnection();
                buttonCartrigesOnRepair.Text = cmd.ExecuteScalar().ToString();
                dataBase.closeConnection();
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
            dgw.Rows.Add( record.GetString(1), record.GetString(2));
        }

        private void buttonCartrigesOnRepair_Click(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView);
        }

    }
}