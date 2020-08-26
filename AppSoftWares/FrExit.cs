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
using System.Data.SqlClient;

namespace AppSoftWares
{
    public partial class FrExit : MetroFramework.Forms.MetroForm
    {
        public FrExit()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection con = new SqlConnection();
        PersianCalendar pc = new PersianCalendar();
        int product_id;
        string driver_phone;
        private void FrExit_Load(object sender, EventArgs e)
        {
            try
            {
                maskedTextBox2.Text = DateTime.Now.ToString("MM/dd/yyyy");
                maskedTextBox1.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("0,0") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("0,0");



            }
            catch
            {

            }
        }

        private void txt_factor_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_factor_id.Text == string.Empty)
            {
                errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                errorProvider7.Clear();
            }
            else
            {

                int rec = Enters.ExistEnter(Convert.ToInt32(txt_factor_id.Text));

                if (rec >= 1)
                {
                    
                    product_id = Enters.SelectIdProduct(Convert.ToInt32(txt_factor_id.Text));
                    txt_product.Text = Products.SelectProducts(product_id);
                    //txt_driver_ir.Text = Driver.SelectTruckDriver(Enters.SelectIdDriver(Convert.ToInt32(txt_factor_id.Text)));

                    con.ConnectionString = @"Data Source = . ; Initial Catalog = SoftWareDatabase ; Integrated Security = true;";
                    SqlCommand cmd1 = new SqlCommand("select truck_number from Driver_Table where id in(select driver_id from Enter_Table where factor_id=@a)", con);
                    cmd1.Parameters.AddWithValue("@a", Convert.ToInt32(txt_factor_id.Text));
                    con.Open();

                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    AutoCompleteStringCollection mycollection1 = new AutoCompleteStringCollection();
                    while (dr1.Read())
                    {
                        mycollection1.Add(dr1.GetString(0));
                    }
                    txt_driver_ir.AutoCompleteCustomSource = mycollection1;
                    con.Close();

                    SqlCommand cmd = new SqlCommand("select truck_number from Driver_Table where truck_number not in (select truck_irq from Exit_Table where factor_id = @b )", con);
                    cmd.Parameters.AddWithValue("@b", Convert.ToInt32(txt_factor_id.Text));
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
                    while (dr.Read())
                    {
                        mycollection.Add(dr.GetString(0));
                    }
                    txt_driver_iq.AutoCompleteCustomSource = mycollection;
                    con.Close();


                    errorProvider7.SetError(txt_factor_id, " ");
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.SetError(txt_factor_id, "شماره فاکتور ثبت نشده است");
                    errorProvider7.Clear();
                }
            }
        }

        private void txt_driver_ir_TextChanged(object sender, EventArgs e)
        {
            if (txt_driver_ir.Text == string.Empty)
            {
                errorProvider2.SetError(txt_driver_ir, "شماره ماشین نباید خالی باشد");
                errorProvider8.Clear();
            }
            else
            {
                int der = Driver.ExistPhone(txt_driver_ir.Text);
                if (der == 1)
                {
                    int id_driver = Driver.SelectIdDrivers(txt_driver_ir.Text);
                    txt_weight.Text = Enters.SelectEnterWeights(Convert.ToInt32(txt_factor_id.Text), id_driver).ToString();

                    errorProvider8.SetError(txt_driver_ir, " ");
                    errorProvider2.Clear();
                }
                else
                {
                    errorProvider2.SetError(txt_driver_ir, "شماره ماشین را با دقت وارد نمایید");
                    errorProvider8.Clear();
                }
 
            }

        }

        private void txt_driver_iq_TextChanged(object sender, EventArgs e)
        {
            if (txt_driver_iq.Text == string.Empty)
            {
                errorProvider3.SetError(txt_driver_iq, "شماره ماشین نباید خالی باشد");
                errorProvider9.Clear();
            }
            else
            {
                int der = Driver.ExistPhone(txt_driver_iq.Text);
                if (der == 1)
                {
                    driver_phone = Driver.SelectPhone(txt_driver_iq.Text);
                    errorProvider9.SetError(txt_driver_iq, " ");
                    errorProvider3.Clear();
                }
                else
                {
                    errorProvider3.SetError(txt_driver_iq, "شماره ماشین را با دقت انتخاب کنید");
                    errorProvider9.Clear();
                }
     


            }
        }

        private void txt_customer_TextChanged(object sender, EventArgs e)
        {
            if (txt_customer.Text == string.Empty)
            {
                errorProvider4.SetError(txt_customer, "طرف حساب نباید خالی باشد");
                errorProvider10.Clear();
            }
            else
            {
                errorProvider10.SetError(txt_customer, " ");
                errorProvider4.Clear();
            }
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            if (txt_weight.Text == string.Empty)
            {
                errorProvider5.SetError(txt_weight, "وزن نباید خالی باشد");
                errorProvider11.Clear();
            }
            else
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                errorProvider11.SetError(txt_weight, " ");
                errorProvider5.Clear();
            }
        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            if (txt_product.Text == string.Empty)
            {
                errorProvider6.SetError(txt_product, "نوع محصول نباید خالی باشد");
                errorProvider12.Clear();
            }
            else
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                errorProvider12.SetError(txt_product, " ");
                errorProvider6.Clear();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (txt_factor_id.Text == string.Empty)
            {
                errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                errorProvider7.Clear();
            }
            if (txt_driver_ir.Text == string.Empty)
            {
                errorProvider2.SetError(txt_driver_ir, "شماره ماشین نباید خالی باشد");
                errorProvider8.Clear();
            }
            if (txt_driver_iq.Text == string.Empty)
            {
                errorProvider3.SetError(txt_driver_iq, "شماره ماشین نباید خالی باشد");
                errorProvider9.Clear();
            }
            if (txt_weight.Text == string.Empty)
            {
                errorProvider5.SetError(txt_weight, "وزن نباید خالی باشد");
                errorProvider11.Clear();
            }
            if (txt_customer.Text == string.Empty)
            {
                errorProvider4.SetError(txt_customer, "نام طرف حساب نباید خالی باشد");
                errorProvider10.Clear();
            }
            if (txt_product.Text == string.Empty)
            {
                errorProvider6.SetError(txt_product, "نام محصول نباید خالی باشد");
                errorProvider12.Clear();
            }
            else if (errorProvider1.GetError(txt_factor_id).Length < 1 && errorProvider2.GetError(txt_driver_ir).Length < 1 && errorProvider3.GetError(txt_driver_iq).Length < 1 && errorProvider4.GetError(txt_customer).Length < 1 && errorProvider5.GetError(txt_weight).Length < 1 && errorProvider6.GetError(txt_product).Length < 1)
            {
                int result = Exits.InsertExit(Convert.ToInt32(txt_factor_id.Text), txt_driver_ir.Text, txt_driver_iq.Text, driver_phone, Convert.ToDecimal(txt_weight.Text), product_id, txt_cotash.Text, txt_barname.Text, maskedTextBox1.Text, maskedTextBox2.Text, txt_customer.Text, txt_description.Text);
                if (result == 1)
                {
                    DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txt_barname.Text = string.Empty;
                        txt_cotash.Text = string.Empty;
                        txt_factor_id.Text = string.Empty;
                        txt_customer.Text = string.Empty;
                        txt_weight.Text = string.Empty;
                        txt_driver_iq.Text = string.Empty;
                        txt_driver_ir.Text = string.Empty;
                        txt_description.Text = string.Empty;
                    }
                    else
                    {
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("مشکل در ذخیره داده ها لطفا دقت فرمایید", "گزارش");
                }
            }
        }

        private void txt_factor_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txt_cotash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) )
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txt_barname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void txt_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            }
        }
    }
}
