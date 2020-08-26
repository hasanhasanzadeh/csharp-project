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
    public partial class FrEditCash : MetroFramework.Forms.MetroForm
    {
        public FrEditCash()
        {
            InitializeComponent();
        }

        private void cash_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cash_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروزرسانی انجام شد","گزارش");
            cash_TableDataGridView.Refresh();
        }

        private void FrEditCash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Cash_Table' table. You can move, or remove it, as needed.
            this.cash_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Cash_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cash_TableBindingSource.DataSource = Cash.SelectLikeCash(metroTextBox1.Text);
                cash_TableDataGridView.Refresh();
            }
            catch
            {

            }
        }

        private void cash_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cash_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        cash_TableBindingSource.RemoveCurrent();
                        this.cash_TableTableAdapter.Update(this.softWareDatabaseDataSet.Cash_Table);
                        cash_TableDataGridView.Refresh();
                    }
                }
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
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
