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
    public partial class FrChangeUser : MetroFramework.Forms.MetroForm
    {
        public FrChangeUser()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text == string.Empty)
                {
                    errorProvider5.Clear();
                    errorProvider1.SetError(txt_user, "نام کاربری جدید نباید خالی باشد");
                }
                if (txt_password.Text == string.Empty)
                {
                    errorProvider6.Clear();
                    errorProvider2.SetError(txt_password, "کلمه عبور جدید نباید خالی باشد");
                }
                if (txt_confirm.Text == string.Empty)
                {
                    errorProvider7.Clear();
                    errorProvider3.SetError(txt_confirm, "تایید کلمه عبور جدید نباید خالی باشد");
                }
                if (txt_passwordold.Text == string.Empty)
                {
                    errorProvider8.Clear();
                    errorProvider4.SetError(txt_passwordold, "کلمه عبور قدیم نباید خالی باشد");
                }
                if (txt_password.Text != txt_confirm.Text)
                {
                    errorProvider3.SetError(txt_password, "تایید کلمه عبور مطابقت ندارد");
                    errorProvider7.Clear();
                }

                else if (txt_user.Text != string.Empty && txt_password.Text == txt_confirm.Text && txt_passwordold.Text != string.Empty && txt_password.Text != string.Empty && txt_confirm.Text != string.Empty)
                {

                    int updateUser = Users.UpdateUser(txt_user.Text, txt_password.Text, txt_passwordold.Text);
                    if (updateUser == 1)
                    {

                        DialogResult dr = MessageBox.Show("نام کاربری و کله عبور با موفقیت تغییر کرد", "گزارش", MessageBoxButtons.OKCancel);
                        if (dr == DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {
                            txt_user.Text = string.Empty;
                            txt_password.Text = string.Empty;
                            txt_confirm.Text = string.Empty;
                            txt_passwordold.Text = string.Empty;
                        }

                    }
                    else
                    {
                        MessageBox.Show("کلمه عبور قدیم تطابق ندارد لطفا با دقت وارد نمایید", "گزارش");
                        txt_user.Text = string.Empty;
                        txt_password.Text = string.Empty;
                        txt_confirm.Text = string.Empty;
                        txt_passwordold.Text = string.Empty;
                    }
                }

            }
            catch
            {
               // MessageBox.Show(e.ToString());
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

        private void txt_user_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_user, "نام کاربری جدید نباید خالی باشد");
                    errorProvider5.Clear();
                }
                else
                {
                    errorProvider5.SetError(txt_user, " ");
                    errorProvider1.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text == string.Empty)
                {
                    errorProvider2.SetError(txt_password, "کلمه عبور جدید نباید خالی باشد");
                    errorProvider6.Clear();
                }
                else
                {
                    errorProvider6.SetError(txt_password, " ");
                    errorProvider2.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_confirm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_confirm.Text == string.Empty)
                {
                    errorProvider3.SetError(txt_confirm, "تایید کلمه عبور جدید نباید خالی باشد");
                    errorProvider7.Clear();
                }
                else if (txt_confirm.Text == txt_password.Text)
                {
                    errorProvider7.SetError(txt_confirm, " ");
                    errorProvider3.Clear();
                }
                else
                {
                    errorProvider3.SetError(txt_confirm, "تایید کلمه عبور تطابق ندارد لطفا دقت فرمایید");
                    errorProvider7.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        

        private void txt_passwordold_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_passwordold.Text == string.Empty)
                {
                    errorProvider4.SetError(txt_passwordold, "کلمه عبور قدیم نباید خالی باشد");
                    errorProvider8.Clear();
                }
                else
                {
                    errorProvider8.SetError(txt_passwordold, " ");
                    errorProvider4.Clear();
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_confirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) )
            {
               // e.Handled = true;
            }
            else
            {
               // e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txt_passwordold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                //e.Handled = true;
            }
            else
            {
               // e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
