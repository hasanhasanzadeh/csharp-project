using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSoftWares
{
    public partial class FrEditDriver : MetroFramework.Forms.MetroForm
    {
        public FrEditDriver()
        {
            InitializeComponent();
        }

        private void driver_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driver_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروز رسانی انجام شد","گزارش");
            driver_TableDataGridView.Refresh();
        }

        private void FrEditDriver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Driver_Table' table. You can move, or remove it, as needed.
            this.driver_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Driver_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                driver_TableBindingSource.DataSource = Driver.SelectLikeDriver(metroTextBox1.Text);
                driver_TableDataGridView.Refresh();
            }
            catch
            {

            }
        }

        private void driver_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (driver_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        driver_TableBindingSource.RemoveCurrent();
                        this.driver_TableTableAdapter.Update(this.softWareDatabaseDataSet.Driver_Table);
                        driver_TableDataGridView.Refresh();
                    }
                }
            }
            catch
            {
               // MessageBox.Show(e.ToString());
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                //e.Handled = true;
            }
            else
            {
                //e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
