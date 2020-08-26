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
    public partial class FrEditCompany : MetroFramework.Forms.MetroForm
    {
        public FrEditCompany()
        {
            InitializeComponent();
        }


        private void FrEditCompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Company_Table' table. You can move, or remove it, as needed.
            this.company_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Company_Table);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.company_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.softWareDatabaseDataSet);
            MessageBox.Show("بروز رسانی انجام شد","گزارش");
        
        }
    }
}
