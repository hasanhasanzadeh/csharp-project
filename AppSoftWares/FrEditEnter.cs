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
    public partial class FrEditEnter : MetroFramework.Forms.MetroForm
    {
        public FrEditEnter()
        {
            InitializeComponent();
        }

        private void enter_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.enter_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروز رسانی داده ها با موفقیت انجام شد", "گزارش");
            enter_TableDataGridView.Refresh();
        }

        private void FrEditEnter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Enter_Table' table. You can move, or remove it, as needed.
            this.enter_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Enter_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                enter_TableBindingSource.DataSource = Enters.SelectLikeEnter(metroTextBox1.Text);
                enter_TableDataGridView.Refresh();
            }
            catch
            {

            }
        }

        private void enter_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (enter_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        enter_TableBindingSource.RemoveCurrent();
                        this.enter_TableTableAdapter.Update(this.softWareDatabaseDataSet.Enter_Table);
                        enter_TableDataGridView.Refresh();
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
