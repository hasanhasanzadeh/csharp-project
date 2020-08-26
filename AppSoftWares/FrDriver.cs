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
    public partial class FrDriver : MetroFramework.Forms.MetroForm
    {
        public FrDriver()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
               // MessageBox.Show("فیلد ها نباید خالی باشند","گزارش");
            }
            catch
            {

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (met_name.Text == string.Empty)
                {
                    errorProvider1.SetError(met_name, "نام راننده نباید خالی باشد");
                    errorProvider4.Clear();
                }
                if (met_truck_number.Text == string.Empty)
                {
                    errorProvider2.SetError(met_truck_number, "شماره ماشین نباید خالی باشد");
                    errorProvider5.Clear();
                }
                if (met_tel.Text == string.Empty)
                {
                    errorProvider3.SetError(met_tel, "شماره ماشین نباید خالی باشد");
                    errorProvider6.Clear();
                }

               else if (errorProvider1.GetError(met_name).Length < 1 && errorProvider2.GetError(met_truck_number).Length < 1 && errorProvider3.GetError(met_tel).Length < 1 )
                {
                    
                    int result = Driver.InsertDriver(met_name.Text, met_tel.Text, met_truck_number.Text, met_code_mel.Text, met_address.Text, met_descriptions.Text,met_number_cart.Text);
                    if (result == 1)
                    {
                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            met_address.Text = string.Empty;
                            met_name.Text = string.Empty;
                            met_tel.Text = string.Empty;
                            met_truck_number.Text = string.Empty;
                            met_descriptions.Text = string.Empty;
                            met_code_mel.Text = string.Empty;
                            met_number_cart.Text = string.Empty;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد ها را پر کنید", "گزارش");
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        } 

        private void met_truck_number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (met_truck_number.Text == string.Empty)
                {
                    errorProvider2.SetError(met_truck_number, "شماره ماشین نباید خالی باشد");
                    errorProvider5.Clear();
                }
                else
                {
                    int res = Driver.ExistDriver(met_truck_number.Text);
                    if (res >= 1)
                    {
                        errorProvider2.SetError(met_truck_number, "شماره ماشین قبلا ثبت شده است");
                        errorProvider5.Clear();
                    }
                    else
                    {
                        errorProvider5.SetError(met_truck_number, " ");
                        errorProvider2.Clear();
                    }

                }
            }
            catch
            {

            }
        }

        private void met_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (met_name.Text == string.Empty)
                {
                    errorProvider1.SetError(met_name, "نام راننده نباید خالی باشد");
                    errorProvider4.Clear();
                }
                else
                {
                    int res = Driver.ExistDrivers(met_name.Text);
                    if (res >= 1)
                    {
                        errorProvider1.SetError(met_name, "نام راننده قبلا ثبت شده است");
                        errorProvider4.Clear();
                    }
                    else
                    {
                        errorProvider4.SetError(met_name, " ");
                        errorProvider1.Clear();
                    }

                }
            }
            catch
            {

            }
        }

        private void met_tel_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (met_tel.Text == string.Empty)
                {
                    errorProvider3.SetError(met_tel, "شماره ماشین نباید خالی باشد");
                    errorProvider6.Clear();
                }
                else
                {
                    int res = Driver.ExistDriverMobile(met_tel.Text);
                    if (res >= 1)
                    {
                        errorProvider3.SetError(met_tel, "شماره موبایل مورد نظر قبلا ثبت شده است");
                        errorProvider6.Clear();
                    }
                    else
                    {
                        errorProvider6.SetError(met_tel, " ");
                        errorProvider3.Clear();
                    }

                }
            }
            catch
            {

            }
        }

        private void met_tel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void met_code_mel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void met_number_cart_KeyPress(object sender, KeyPressEventArgs e)
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

        private void met_name_KeyPress(object sender, KeyPressEventArgs e)
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

        private void met_truck_number_KeyPress(object sender, KeyPressEventArgs e)
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

        private void met_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
            {
               // e.Handled = true;
            }
            else
            {
                //e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void met_descriptions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
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
