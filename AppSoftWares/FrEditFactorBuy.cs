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
    public partial class FrEditFactorBuy : MetroFramework.Forms.MetroForm
    {
        public FrEditFactorBuy()
        {
            InitializeComponent();
        }

        private void factor_Buy_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factor_Buy_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروز رسانی داده ها با موفقیت انجام شد", "گزارش");
            factor_Buy_TableDataGridView.Refresh();
        }

        private void FrEditFactorBuy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Factor_Buy_Table' table. You can move, or remove it, as needed.
            this.factor_Buy_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Factor_Buy_Table);

        }

        

        private void factor_Buy_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (factor_Buy_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        factor_Buy_TableBindingSource.RemoveCurrent();
                        this.factor_Buy_TableTableAdapter.Update(this.softWareDatabaseDataSet.Factor_Buy_Table);
                        factor_Buy_TableDataGridView.Refresh();
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

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                factor_Buy_TableBindingSource.DataSource = Factors.SelectLikeFactorBuy(metroTextBox1.Text);
                factor_Buy_TableDataGridView.Refresh();
            }
            catch
            {

            }
        }


    }
}
