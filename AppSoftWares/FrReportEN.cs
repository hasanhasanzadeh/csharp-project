using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report;

namespace AppSoftWares
{
    public partial class FrReportEN : MetroFramework.Forms.MetroForm
    {
    
        public FrReportEN()
        {
            InitializeComponent();
        }

        private void FrReportEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.View_Enter' table. You can move, or remove it, as needed.
            this.view_EnterTableAdapter.Fill(this.softWareDatabaseDataSet.View_Enter);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                view_EnterBindingSource.DataSource = Enters.SelectLikeEnte(Convert.ToInt32(textBox1.Text));
                view_EnterDataGridView.Refresh();
            }
            catch
            {

            }
       
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            softWareDatabaseDataSet.View_Enter.Clear();
            DataTable dt;
            dt = new DataTable();
            dt.TableName = "view_enter";
            foreach (DataGridViewColumn col in view_EnterDataGridView.Columns)
            {
                dt.Columns.Add(col.DataPropertyName, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in view_EnterDataGridView.Rows)
            {
                if (gridRow.IsNewRow)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < view_EnterDataGridView.Columns.Count; i1++)
                    dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                dt.Rows.Add(dtRow);
            }
            softWareDatabaseDataSet.Tables.Add(dt);

            PersianCalendar pr = new PersianCalendar();
            string ShamsiDate = pr.GetYear(DateTime.Now).ToString() + "/" + pr.GetMonth(DateTime.Now).ToString("0,0") + "/" + pr.GetDayOfMonth(DateTime.Now).ToString("0,0");
            StiVariable sv = new StiVariable("Date", "ShamsiDate", typeof(string), ShamsiDate, false);

            stiReport1.Load(System.Windows.Forms.Application.StartupPath + @"\ReportViewEn.mrt");
            stiReport1.RegData("softWareDatabaseDataSet", softWareDatabaseDataSet);
            stiReport1.Dictionary.Variables.Add(sv);
            stiReport1.Show();
        }
    }
}
