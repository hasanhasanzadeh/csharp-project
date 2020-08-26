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


namespace AppSoftWares
{
    public partial class FrCash : MetroFramework.Forms.MetroForm
    {
        public FrCash()
        {
            InitializeComponent();
        }
        PersianCalendar pc = new PersianCalendar();
        decimal dstock;
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



        private void combo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_type.Text == string.Empty)
                {
                    errorProvider2.SetError(combo_type, "نوع نباید خالی باشد");
                    errorProvider6.Clear();
                }
                else
                {

                    errorProvider6.SetError(combo_type, " ");
                    errorProvider2.Clear();

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == string.Empty)
                {
                    errorProvider3.SetError(comboBox2, "نوع ارز نباید خالی باشد");
                    errorProvider7.Clear();
                }
                else
                {

                    errorProvider7.SetError(comboBox2, " ");
                    errorProvider3.Clear();

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_price.Text == string.Empty)
                {
                    errorProvider4.SetError(txt_price, "مبلغ نباید خالی باشد");
                    errorProvider8.Clear();
                }
                else
                {
                    
                    errorProvider8.SetError(txt_price, " ");
                    errorProvider4.Clear();

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_factor_id.Text == string.Empty)
            {
                errorProvider1.SetError(txt_factor_id, "شماره پیش فاکتور نباید خالی باشد");
                errorProvider5.Clear();
            }
            if (combo_type.Text == string.Empty)
            {
                errorProvider2.SetError(combo_type, "نوع نباید خالی باشد");
                errorProvider6.Clear();
            }
            if (comboBox2.Text == string.Empty)
            {
                errorProvider3.SetError(comboBox2, "نوع ارز نباید خالی باشد");
                errorProvider7.Clear();
            }
            if (txt_price.Text == string.Empty)
            {
                errorProvider4.SetError(txt_price, "مبلغ نباید خالی باشد");
                errorProvider8.Clear();
            }
            else if (errorProvider1.GetError(txt_factor_id).Length < 1 && errorProvider2.GetError(combo_type).Length < 1 && errorProvider3.GetError(comboBox2).Length < 1 && errorProvider4.GetError(txt_price).Length < 1)
            {
                int dri = Cash.ExistCash(Convert.ToInt32(txt_factor_id.Text));
                if (dri < 1 )
                {
                    dstock = 0;
                }
                else if (dri >= 1)
                {
                    string stock = Cash.ReturnCash(Convert.ToInt32(txt_factor_id.Text));
                    dstock = Convert.ToDecimal(stock);
                }
                if (combo_type.SelectedIndex == 0)
                {
                    decimal dc = dstock + Convert.ToDecimal(txt_price.Text);
                    int c = Cash.InsertCash(Convert.ToInt32(txt_factor_id.Text), txt_cash_name.Text, Convert.ToDecimal(txt_price.Text), 0, dc, maskedTextBox1.Text, maskedTextBox2.Text, comboBox2.Text, txt_description.Text);
                    if (c == 1)
                    {
                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txt_price.Text = string.Empty;
                            txt_factor_id.Text = string.Empty;
                            txt_cash_name.Text = string.Empty;
                            txt_description.Text = string.Empty;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("مشکل در ذخیره اطلاعات", "گزارش");
                    }
                }

                else if (combo_type.SelectedIndex == 1)
                {
                    decimal dc = dstock - Convert.ToDecimal(txt_price.Text);
                    int c = Cash.InsertCash(Convert.ToInt32(txt_factor_id.Text), txt_cash_name.Text, 0, Convert.ToDecimal(txt_price.Text), dc, maskedTextBox1.Text, maskedTextBox2.Text, comboBox2.Text, txt_description.Text);
                    if (c == 1)
                    {
                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txt_price.Text = string.Empty;
                            txt_factor_id.Text = string.Empty;
                            txt_cash_name.Text = string.Empty;
                            txt_description.Text = string.Empty;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("مشکل در ذخیره اطلاعات", "گزارش");
                    }
                }
            }
        }

        private void FrCash_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Text = DateTime.Now.ToString("MM/dd/yyyy");
            maskedTextBox1.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("0,0") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("0,0");
        }

        private void txt_factor_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                 if (txt_factor_id.Text != string.Empty)
                {
                    int result = Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text));
                    if(result<1)
                    {
                        errorProvider1.SetError(txt_factor_id, "شماره فاکتور ثبت نشده است لطفا اول شماره فاکتور را ثبت نمایید");
                        errorProvider5.Clear();
                    }
                    else if(result >= 1)
                    {
                        errorProvider5.SetError(txt_factor_id, " ");
                        errorProvider1.Clear();
                    }


                }
                else if (txt_factor_id.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                    errorProvider5.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                else
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    e.Handled = false;

                }
            }
            catch
            {
            }
        }

        private void txt_factor_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
                else
                {

                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    e.Handled = false;
                }
                    
            }
            catch
            {

            }
        }

        private void txt_cash_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        

        private void txt_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

      
    }
}
