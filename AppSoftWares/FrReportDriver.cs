using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report;

namespace AppSoftWares
{
    public partial class FrReportDriver : MetroFramework.Forms.MetroForm
    {
        public FrReportDriver()
        {
            InitializeComponent();
        }


        private void FrReportDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Driver_Table' table. You can move, or remove it, as needed.
            this.driver_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Driver_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            driver_TableBindingSource.DataSource = Driver.SelectLikeDriver(metroTextBox1.Text);
            driver_TableDataGridView.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //softWareDatabaseDataSet.Driver_Table.Clear();
            //DataTable dt = new DataTable();
            //dt.TableName = "Driver_Table";
            //foreach (DataGridViewColumn col in driver_TableDataGridView.Columns)
            //{
            //    dt.Columns.Add(col.DataPropertyName, col.ValueType);
            //}
            //foreach (DataGridViewRow gridRow in driver_TableDataGridView.Rows)
            //{
            //    if (gridRow.IsNewRow)
            //        continue;
            //    DataRow dtRow = dt.NewRow();
            //    for (int i1 = 0; i1 < driver_TableDataGridView.Columns.Count; i1++)
            //        dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
            //    dt.Rows.Add(dtRow);
            //}
            //softWareDatabaseDataSet.Tables.Add(dt);

            //PersianCalendar pr = new PersianCalendar();
            //stiReport1.Load(System.Windows.Forms.Application.StartupPath + @"\ReportDriver.mrt");
            //string ShamsiDate = pr.GetYear(DateTime.Now).ToString() + "/" + pr.GetMonth(DateTime.Now).ToString("0,0") + "/" + pr.GetDayOfMonth(DateTime.Now).ToString("0,0");
            //StiVariable sv = new StiVariable("Date", "ShamsiDate", typeof(string), ShamsiDate, false);
            //stiReport1.RegData("Driver_Table", softWareDatabaseDataSet);
            //stiReport1.Dictionary.Variables.Add(sv);
            //stiReport1.Show();

            softWareDatabaseDataSet.Clear();
            DataTable dt;
            dt = new DataTable();
            dt.TableName = "driver_table";
            foreach (DataGridViewColumn col in driver_TableDataGridView.Columns)
            {
                dt.Columns.Add(col.DataPropertyName, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in driver_TableDataGridView.Rows)
            {
                if (gridRow.IsNewRow)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < driver_TableDataGridView.Columns.Count; i1++)
                    dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                dt.Rows.Add(dtRow);
            }
            softWareDatabaseDataSet.Tables.Add(dt);

            PersianCalendar pr = new PersianCalendar();
            string ShamsiDate = pr.GetYear(DateTime.Now).ToString() + "/" + pr.GetMonth(DateTime.Now).ToString("0,0") + "/" + pr.GetDayOfMonth(DateTime.Now).ToString("0,0");
            StiVariable sv = new StiVariable("Date", "ShamsiDate", typeof(string), ShamsiDate, false);
            
            stiReport1.Load(System.Windows.Forms.Application.StartupPath + @"\ReportDriver.mrt");
            stiReport1.RegData("softWareDatabaseDataSet", softWareDatabaseDataSet);
            stiReport1.Dictionary.Variables.Add(sv);
            stiReport1.Show();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
               // e.Handled = true;
            }
            else
            {
                //e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
