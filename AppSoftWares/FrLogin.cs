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
    public partial class FrLogin : MetroFramework.Forms.MetroForm
    {
        public FrLogin()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                 if (metroTextBox1.Text != string.Empty && metroTextBox2.Text != string.Empty)
                {

                    int user = Users.ExistUser(metroTextBox1.Text.Replace("'", ""), metroTextBox2.Text.Replace("'", ""));
                    if (user == 1)
                    {
                            this.Visible = false;
                            FrMain frmain = new FrMain();
                            frmain.Show();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا کلمه عبور اشتباه می باشد", "گزارش");
                    }
                }
                else
                {
                    MessageBox.Show("نام کاربری یا کلمه عبور نباید خالی باشد", "گزارش");
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == string.Empty)
            {
                metroTextBox1.WithError = true;
            }
            else
            {
                metroTextBox1.WithError = false;
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text == string.Empty)
            {
                metroTextBox2.WithError = true;
            }
            else
            {
                metroTextBox2.WithError = false;
            }
        }
    }
}
