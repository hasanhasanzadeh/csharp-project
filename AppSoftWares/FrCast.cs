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
    public partial class FrCast : MetroFramework.Forms.MetroForm
    {
        public FrCast()
        {
            InitializeComponent();
        }
        PersianCalendar pc = new PersianCalendar();
        private void FrCast_Load(object sender, EventArgs e)
        {
            maskedTextBox2.Text = DateTime.Now.ToString("MM/dd/yyyy");
            maskedTextBox1.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("0,0") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("0,0");
        }

        private void txt_cost_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_cost_id.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_cost_id, "شماره فاکتور نباید خالی باشد");
                    errorProvider4.Clear();
                }
                else
                {
                    int result = Factors.ExistFactorBuy(Convert.ToInt32(txt_cost_id.Text));
                    if (result == 0)
                    {
                        errorProvider1.SetError(txt_cost_id, "شماره فاکتور نباید خالی باشد");
                        errorProvider4.Clear();
                        
                    }
                    else
                    {
                        errorProvider4.SetError(txt_cost_id, " ");
                        errorProvider1.Clear();
                    }
                    

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == string.Empty)
                {
                    errorProvider2.SetError(comboBox1, "نوع نباید خالی باشد");
                    errorProvider5.Clear();
                }
                else
                {


                    errorProvider5.SetError(comboBox1, " ");
                    errorProvider2.Clear();

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_cost.Text == string.Empty)
                {
                    errorProvider3.SetError(txt_cost, "مبلغ نباید خالی باشد");
                    errorProvider6.Clear();
                }
                else
                {
                    errorProvider6.SetError(txt_cost, " ");
                    errorProvider3.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
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
        decimal dstock;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_cost_id.Text == string.Empty)
            {
                errorProvider1.SetError(txt_cost_id, "شماره صندوق نباید خالی باشد");
                errorProvider4.Clear();
            }
            if (txt_cost.Text == string.Empty)
            {
                errorProvider3.SetError(txt_cost, "مبلغ نباید خالی باشد");
                errorProvider6.Clear();
            }
            if (comboBox1.Text == string.Empty)
            {
                errorProvider2.SetError(comboBox1, "نوع نباید خالی باشد");
                errorProvider5.Clear();
            }
            else if (errorProvider1.GetError(txt_cost_id).Length < 1 && errorProvider3.GetError(txt_cost).Length < 1 && errorProvider2.GetError(comboBox1).Length < 1)
            {
                int dri = Cost.ExistCashEx(Convert.ToInt32(txt_cost_id.Text));
                if (dri == 0)
                {
                    dstock = 0;
                }
                else if (dri >= 1)
                {
                    string stock = Cost.ReturnCashEx(Convert.ToInt32(txt_cost_id.Text));
                    dstock = Convert.ToDecimal(stock);
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    decimal dc = dstock + Convert.ToDecimal(txt_cost.Text);
                    int c = Cost.InsertCashEx(Convert.ToInt32(txt_cost_id.Text), Convert.ToDecimal(txt_cost.Text), 0, dc, maskedTextBox1.Text, maskedTextBox2.Text, txt_description.Text);
                    if (c == 1)
                    {
                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txt_cost.Text = string.Empty;
                            txt_cost_id.Text = string.Empty;
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

                else if (comboBox1.SelectedIndex == 1)
                {
                    decimal dc = dstock - Convert.ToDecimal(txt_cost.Text);
                    int c = Cost.InsertCashEx(Convert.ToInt32(txt_cost_id.Text), 0, Convert.ToDecimal(txt_cost.Text), dc, maskedTextBox1.Text, maskedTextBox2.Text, txt_description.Text);
                    if (c == 1)
                    {
                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txt_cost.Text = string.Empty;
                            txt_cost_id.Text = string.Empty;
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

        private void txt_cost_KeyPress(object sender, KeyPressEventArgs e)
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
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_cost_id_KeyPress(object sender, KeyPressEventArgs e)
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
                //MessageBox.Show(e.ToString());
            }
        }

        
    }
}
