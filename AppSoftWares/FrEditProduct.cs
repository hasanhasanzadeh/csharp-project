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
    public partial class FrEditProduct : MetroFramework.Forms.MetroForm
    {
        public FrEditProduct()
        {
            InitializeComponent();
        }

        private void product_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("داده ها با موفقیت بروز رسانی شد", "گزارش");
            product_TableDataGridView.Refresh();
        }

        private void FrEditProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Product_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                product_TableBindingSource.DataSource = Products.SelectLikeProduct(metroTextBox1.Text);
                product_TableDataGridView.Refresh();
            }
            catch
            {

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

        private void product_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (product_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        product_TableBindingSource.RemoveCurrent();
                        this.product_TableTableAdapter.Update(this.softWareDatabaseDataSet.Product_Table);
                        product_TableDataGridView.Refresh();
                    }
                }
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
