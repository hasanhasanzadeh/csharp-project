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
    public partial class FrReportEnter : MetroFramework.Forms.MetroForm
    {
        public FrReportEnter()
        {
            InitializeComponent();
        }

        private void enter_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enter_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);

        }

        private void FrReportEnter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Enter_Table' table. You can move, or remove it, as needed.
            this.enter_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Enter_Table);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            softWareDatabaseDataSet.Clear();
            DataTable dt;
            dt = new DataTable();
            dt.TableName = "enter_table";
            foreach (DataGridViewColumn col in enter_TableDataGridView.Columns)
            {
                dt.Columns.Add(col.DataPropertyName, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in enter_TableDataGridView.Rows)
            {
                if (gridRow.IsNewRow)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < enter_TableDataGridView.Columns.Count; i1++)
                    dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                dt.Rows.Add(dtRow);
            }
            softWareDatabaseDataSet.Tables.Add(dt);

            PersianCalendar pr = new PersianCalendar();
            string ShamsiDate = pr.GetYear(DateTime.Now).ToString() + "/" + pr.GetMonth(DateTime.Now).ToString("0,0") + "/" + pr.GetDayOfMonth(DateTime.Now).ToString("0,0");
            StiVariable sv = new StiVariable("Date", "ShamsiDate", typeof(string), ShamsiDate, false);

            stiReport1.Load(System.Windows.Forms.Application.StartupPath + @"\ReportEnter.mrt");
            stiReport1.RegData("softWareDatabaseDataSet", softWareDatabaseDataSet);
            stiReport1.Dictionary.Variables.Add(sv);
            stiReport1.Show();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnterD(metroTextBox1.Text, maskedTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }
                else
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnter(metroTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }



            }
            catch
            {

            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnterD(metroTextBox1.Text, maskedTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }
                else
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnter(metroTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }



            }
            catch
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnterD(metroTextBox1.Text, maskedTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }
                else
                {
                    enter_TableBindingSource.DataSource = Enters.SelectLikeEnter(metroTextBox1.Text);
                    enter_TableDataGridView.Refresh();
                }



            }
            catch
            {

            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
            {
                //e.Handled = true;
            }
            else
            {
               // e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
