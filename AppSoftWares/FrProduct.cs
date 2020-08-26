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
    public partial class FrProduct : MetroFramework.Forms.MetroForm
    {
        public FrProduct()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txt_product_name.Text == string.Empty)
            {
                errorProvider1.SetError(txt_product_name, "نام محصول نمی تواند خالی باشد");
                errorProvider3.Clear();
            }
            else if (txt_product_name.Text != string.Empty && errorProvider1.GetError(txt_product_name).Length < 1)
            {
                int result = Products.InsertProduct(txt_product_name.Text,txt_product_type.Text);
                DialogResult dr = MessageBox.Show("محصول مورد نظر با موفقیت ثبت شد ،آیا قصد ثبت محصول دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    txt_product_name.Text = string.Empty;
                    txt_product_type.Text = string.Empty;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txt_product_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_product_name.Text == string.Empty)
            {
                errorProvider1.SetError(txt_product_name, "نام محصول نباید خالی باشد");
                errorProvider3.Clear();
            }
            else
            {
                int result = Products.ExistProduct(txt_product_name.Text);
                if (result == 1)
                {
                    errorProvider1.SetError(txt_product_name, "محصول مورد نظر قبلا ثبت شده است");
                    errorProvider3.Clear();
                }
                else
                {
                    errorProvider3.SetError(txt_product_name, " ");
                    errorProvider1.Clear();
                }
            }
        }

        

        private void txt_product_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
            
        }

        private void txt_product_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
