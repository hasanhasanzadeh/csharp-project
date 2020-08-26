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
    public partial class FrEditExit : MetroFramework.Forms.MetroForm
    {
        public FrEditExit()
        {
            InitializeComponent();
        }

        private void exit_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.exit_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروز رسانی داده ها با موفقیت انجام شد", "گزارش");
            exit_TableDataGridView.Refresh();
        }

        private void FrEditExit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Exit_Table' table. You can move, or remove it, as needed.
            this.exit_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Exit_Table);

        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                exit_TableBindingSource.DataSource = Exits.SelectLikeExit(metroTextBox1.Text);
                exit_TableDataGridView.Refresh();
            }
            catch
            {

            }
        }

        private void exit_TableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (exit_TableDataGridView.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult dr = MessageBox.Show("آیا سطر مورد نظر را حذف می کنید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        exit_TableBindingSource.RemoveCurrent();
                        this.exit_TableTableAdapter.Update(this.softWareDatabaseDataSet.Exit_Table);
                        exit_TableDataGridView.Refresh();
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
