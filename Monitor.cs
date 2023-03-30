using Npgsql;
using System.Data;

namespace Monitor2
{
    public partial class Monitor : Form
    {
        public Monitor(DateTime pStartDate, DateTime pEndDate, string pIBNum)
        {
            InitializeComponent();
            dpStartDate.Value = pStartDate;
            dpEndDate.Value = pEndDate;
            tbIBnum.Text = pIBNum;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(bRefresh, "Обновить");
            Reload_Data();
        }

        private async void Reload_Data()
        {

            bRefresh.Enabled = false;
            StreamReader sr;
            string sql;
            int[] counts = new int[Settings.sqlPathcount.Length];

            for (int i = 0; i < Settings.sqlPathcount.Length; i++)
            {
                sr = new StreamReader(Settings.sqlPathcount[i]);
                sql = await sr.ReadToEndAsync();
                sql = sql.Replace(":dt1", '\'' + dpStartDate.Value.ToString() + '\'');
                sql = sql.Replace(":dt3", '\'' + dpEndDate.Value.ToString() + '\'');

                if (cbChangeAnalysis.Checked == true) sql = sql.Replace(":dt2", '\'' + dpEndDate.Value.AddDays(1).ToString() + '\'');
                else sql = sql.Replace(":dt2", '\'' + dpEndDate.Value.ToString() + '\'');

                using var newConnection = new NpgsqlConnection(Settings.connString);
                await newConnection.OpenAsync();
                using var newCommand = new NpgsqlCommand(sql, newConnection);
                using (NpgsqlDataReader reader = await newCommand.ExecuteReaderAsync())
                {
                    await reader.ReadAsync();
                    counts[i] = reader.GetInt32(0);
                    newConnection.Close();
                };
            }
            
            //if (counts[0] != 0) bPAD.BackColor = Color.Red;
            bPAD.Text = "Экстренные направления в ПАО:\r\n" + counts[0].ToString();

            //if (counts[1] != 0) bHospII.BackColor = Color.Red;
            bHospII.Text = "Госпитализированные без ИИ:\r\n" + counts[1].ToString();

            //if (counts[2] != 0) bHospLI.BackColor = Color.Red;
            bHospLI.Text = "Госпитализированные без ЛИ:\r\n" + counts[2].ToString();

            //if (counts[3] != 0) bHospLP.BackColor = Color.Red;
            bHospLP.Text = "Госпитализированные без ЛП:\r\n" + counts[3].ToString();

            bRefresh.Enabled = true;
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            Reload_Data();
        }

        private void OpenSQLDataForm(string path)
        {
            Hide();
            SQLData load = new(path, dpStartDate.Value, dpEndDate.Value, cbChangeAnalysis.Checked, tbIBnum.Text);
            load.ShowDialog();
            Close();
        }

        // Функции клика на управляющие кнопки
        private void bPAD_Click(object sender, EventArgs e)
        {
            OpenSQLDataForm(Settings.sqlPath[0]);
        }

        private void bHospII_Click(object sender, EventArgs e)
        {
            OpenSQLDataForm(Settings.sqlPath[1]);
        }

        private void bHospLI_Click(object sender, EventArgs e)
        {
            OpenSQLDataForm(Settings.sqlPath[2]);
        }

        private void bHospIP_Click(object sender, EventArgs e)
        {
            OpenSQLDataForm(Settings.sqlPath[3]);
        }

        private void bLPCheck_Click(object sender, EventArgs e)
        {
            OpenSQLDataForm(Settings.sqlPath[4]);
        }

        private void cbChangeAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            bRefresh_Click(sender, e);
        }

        private void tbIBnum_TextChanged(object sender, EventArgs e)
        {
            if (tbIBnum.Text.Length != 0) bLPCheck.Enabled = true;
            else bLPCheck.Enabled = false;
        }
    }
}