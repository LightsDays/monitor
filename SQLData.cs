using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArrayToExcel;
using System.Diagnostics;

namespace Monitor2
{
    public partial class SQLData : Form
    {
        private string sqlPath;
        private DateTime StartDate;
        private DateTime EndDate;
        private bool CheckAnalysis;
        private string IBNum;

        public SQLData(string psqlPath, DateTime pStartDate, DateTime pEndDate, bool pCheckAnalysis, string pIBNum)
        {
            InitializeComponent();
            sqlPath = psqlPath;
            StartDate = pStartDate;
            EndDate = pEndDate;
            CheckAnalysis = pCheckAnalysis;
            IBNum = pIBNum;
        }

        private void SQLData_Load(object sender, EventArgs e)
        {
            ToolTip t = new();
            t.SetToolTip(bSaveAsExcel, "Сохранить в Excel");
            t.SetToolTip(bBack, "Назад");

            bSaveAsExcel.Enabled = false;
            StreamReader sr = new StreamReader(sqlPath);
            string sql = sr.ReadToEnd();
            sql = sql.Replace(":ibnum", "\'" + IBNum + "%\'");
            sql = sql.Replace(":dt1", '\'' + StartDate.ToString() + '\'');
            sql = sql.Replace(":dt3", '\'' + EndDate.ToString() + '\'');
            if (CheckAnalysis == true) sql = sql.Replace(":dt2", '\'' + EndDate.AddDays(1).ToString() + '\'');
            else sql = sql.Replace(":dt2", '\'' + EndDate.ToString() + '\'');

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Settings.connString);
            DataSet ds = new();
            adapter.Fill(ds);
            dgvSQL.DataSource = ds.Tables[0];
            bSaveAsExcel.Enabled = true;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Hide();
            Monitor load = new(StartDate, EndDate, IBNum);
            load.ShowDialog();
            Close();
        }

        private void bSaveAsExcel_Click(object sender, EventArgs e)
        {
            string fileName = String.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                StreamReader sr = new StreamReader(sqlPath);
                string sql = sr.ReadToEnd();
                sql = sql.Replace(":ibnum", "\'" + IBNum + "%\'");
                sql = sql.Replace(":dt1", '\'' + StartDate.ToString() + '\'');
                sql = sql.Replace(":dt3", '\'' + EndDate.ToString() + '\'');
                if (CheckAnalysis == true) sql = sql.Replace(":dt2", '\'' + EndDate.AddDays(1).ToString() + '\'');
                else sql = sql.Replace(":dt2", '\'' + EndDate.ToString() + '\'');
                NpgsqlDataAdapter adapter = new(sql, Settings.connString);
                DataSet ds = new();
                adapter.Fill(ds);
                dgvSQL.DataSource = ds.Tables[0];
                var excel = ds.ToExcel();
                File.WriteAllBytes(fileName, excel);
                Process.Start(new ProcessStartInfo(fileName) { UseShellExecute = true });
            }
            else return;

            saveFileDialog1.Dispose();
        }
    }
}