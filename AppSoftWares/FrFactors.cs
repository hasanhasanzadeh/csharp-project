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
    public partial class FrFactors : MetroFramework.Forms.MetroForm
    {
        public FrFactors()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        PersianCalendar pc = new PersianCalendar();
        int id_product;

        private void FrFactors_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = @"Data Source = . ; Initial Catalog = SoftWareDatabase ; Integrated Security = true;";
                SqlCommand cmd1 = new SqlCommand("select product_name from Product_Table ", con);
                con.Open();

                SqlDataReader dr1 = cmd1.ExecuteReader();
                AutoCompleteStringCollection mycollection1 = new AutoCompleteStringCollection();
                while (dr1.Read())
                {
                    mycollection1.Add(dr1.GetString(0));
                }
                combo_product_name.AutoCompleteCustomSource = mycollection1;
                con.Close();

                label12.Visible = false;
                maskedTextBox2.Text = DateTime.Now.ToString("MM/dd/yyyy");
                maskedTextBox1.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("0,0") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("0,0");
                // TODO: This line of code loads data into the 'softWareDatabaseDataSet.Product_Table' table. You can move, or remove it, as needed.
                this.product_TableTableAdapter.Fill(this.softWareDatabaseDataSet.Product_Table);
                int result = Products.SelectCountProduct();
                if (result < 1)
                {
                    MessageBox.Show("کالای جهت خرید وجود ندارد لطفا کالای مورد نظر را در کالاها ثبت کنید بعد اقدام به ثبت فاکتور نمایید", "گزارش");
                    FrProduct frproduct = new FrProduct();
                    frproduct.ShowDialog();
                }
                else
                {
                    id_product = Products.SelectIdProduct(combo_product_name.Text);
                }
            }
            catch
            {

            }


        }

        private void txt_factor_id_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_factor_id.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                    errorProvider9.Clear();
                }
                else
                {
                    /* int result = Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text));
                     int results = Factors.ExistFactorSell(Convert.ToInt32(txt_factor_id.Text));
                     if (result >= 1 && results >= 1 )
                     {
                         errorProvider1.SetError(txt_factor_id, "شماره پیش فاکتور قبلا ثبت شده است ");
                         errorProvider9.Clear();
                     }
                     else
                     { */
                    //MessageBox.Show(Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text)).ToString());
                    errorProvider9.SetError(txt_factor_id, " ");
                    errorProvider1.Clear();
                    //}
                }
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }
        decimal dcweight;
        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_quantity.Text == string.Empty)
                {
                    errorProvider5.SetError(txt_quantity, "تناژ نباید خالی باشد");
                    errorProvider13.Clear();
                }
                else
                {
                    errorProvider13.SetError(txt_quantity, " ");
                    errorProvider5.Clear();

                    if (combo_type_factor.SelectedIndex == 1)
                    {
                        if (Convert.ToDecimal(txt_quantity.Text) <= dcweight)
                        {
                            txt_price_sum.Text = (Convert.ToDecimal(txt_price.Text) * Convert.ToDecimal(txt_quantity.Text)).ToString();
                            errorProvider13.SetError(txt_quantity, " ");
                            errorProvider5.Clear();
                        }
                        else
                        {
                            //MessageBox.Show("فروش محصول بیش از خرید مورد نظر می باشد لطفا دقت فرمایید", "گزارش");
                            errorProvider5.SetError(txt_quantity, "فروش محصول بیش از خرید مورد نظر می باشد لطفا دقت فرمایید");
                            errorProvider13.Clear();
                        }
                    }
                    /*
                    if (txt_quantity.Text == "" || txt_quantity.Text == "0") return;
                    decimal quantity;
                    quantity = decimal.Parse(txt_quantity.Text, System.Globalization.NumberStyles.Currency);
                    txt_quantity.Text = quantity.ToString("#,#");
                    txt_quantity.SelectionStart = txt_quantity.Text.Length;
                    if (txt_price_sum.Text == "" || txt_price_sum.Text == "0") return;
                    txt_price_sum.Text = (Convert.ToDecimal(txt_price.Text) * Convert.ToDecimal(txt_quantity.Text)).ToString();
                    decimal price;
                    price = decimal.Parse(txt_price_sum.Text, System.Globalization.NumberStyles.Currency);
                    txt_price_sum.Text = price.ToString("#,#");
                    txt_price_sum.SelectionStart = txt_price_sum.Text.Length;
                    */
                }


            }
            catch
            {

            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_price.Text == string.Empty)
                {
                    errorProvider6.SetError(txt_price, "قیمت واحد نباید خالی باشد");
                    errorProvider14.Clear();
                }
                else
                {
                    errorProvider14.SetError(txt_price, " ");
                    errorProvider6.Clear();
                    txt_price_sum.Text = (Convert.ToDecimal(txt_price.Text) * Convert.ToDecimal(txt_quantity.Text)).ToString();
                    /*
                    txt_price_sum.Text = (Convert.ToDecimal(txt_price.Text) * Convert.ToDecimal(txt_quantity.Text)).ToString();
                    if (txt_price.Text == "" || txt_price.Text == "0") return;
                    decimal quantity;
                    quantity = decimal.Parse(txt_price.Text, System.Globalization.NumberStyles.Currency);
                    txt_price.Text = quantity.ToString("#,#");
                    txt_price.SelectionStart = txt_price.Text.Length;
                    if (txt_price_sum.Text == "" || txt_price_sum.Text == "0") return;
                    decimal price;
                    price = decimal.Parse(txt_price_sum.Text, System.Globalization.NumberStyles.Currency);
                    txt_price_sum.Text = price.ToString("#,#");
                    txt_price_sum.SelectionStart = txt_price_sum.Text.Length;
                    */
                }
            }
            catch
            {

            }
        }

        private void txt_price_sum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_price_sum.Text == string.Empty)
                {
                    errorProvider7.SetError(txt_price_sum, "قیمت کل نباید خالی باشد");
                    errorProvider15.Clear();
                }
                else
                {
                    errorProvider15.SetError(txt_price_sum, " ");
                    errorProvider7.Clear();
                }
            }
            catch
            {
               // MessageBox.Show(e.ToString());
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                else
                    e.Handled = false;
            }
            catch
            {
               // MessageBox.Show(e.ToString());
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
                    e.Handled = false;
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void txt_price_sum_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                else
                    e.Handled = false;
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
                if (txt_factor_id.Text == string.Empty)
                {
                    errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                    errorProvider9.Clear();
                }
                if (combo_type_factor.Text == string.Empty)
                {
                    errorProvider2.SetError(combo_type_factor, "نوع فاکتور نباید خالی باشد");
                    errorProvider10.Clear();
                }
                if (combo_price_type.Text == string.Empty)
                {
                    errorProvider3.SetError(combo_price_type, "نوع ارز نباید خالی باشد");
                    errorProvider11.Clear();
                }
                if (combo_product_name.Text == string.Empty)
                {
                    errorProvider4.SetError(combo_product_name, "نام کالا نباید خالی باشد");
                    errorProvider12.Clear();
                }
                if (txt_quantity.Text == string.Empty)
                {
                    errorProvider5.SetError(txt_quantity, "تناژ نباید خالی باشد");
                    errorProvider13.Clear();
                }
                if (txt_price.Text == string.Empty)
                {
                    errorProvider6.SetError(txt_price, "قیمت واحد نباید خالی باشد");
                    errorProvider14.Clear();
                }
                if (txt_price_sum.Text == string.Empty)
                {
                    errorProvider7.SetError(txt_price_sum, "قیمت کل نباید نباید خالی باشد");
                    errorProvider15.Clear();
                }
                if (txt_customer.Text == string.Empty)
                {
                    errorProvider8.SetError(txt_customer, "نام طرف حساب نباید خالی باشد");
                    errorProvider16.Clear();
                }
                else if (errorProvider1.GetError(txt_factor_id).Length < 1 &&
                    errorProvider2.GetError(combo_type_factor).Length < 1 && 
                    errorProvider3.GetError(combo_price_type).Length < 1 && 
                    errorProvider4.GetError(combo_product_name).Length < 1 && 
                    errorProvider5.GetError(txt_quantity).Length < 1 && 
                    errorProvider6.GetError(txt_price).Length < 1 && 
                    errorProvider7.GetError(txt_price_sum).Length < 1 && 
                    errorProvider8.GetError(txt_customer).Length < 1 )
                {

                    if (combo_type_factor.SelectedIndex == 0)
                    {
                        //MessageBox.Show("0");
                        int res = Factors.InsertFactorBuy(Convert.ToInt32(txt_factor_id.Text), txt_customer.Text, combo_price_type.Text, id_product, Convert.ToDecimal(txt_quantity.Text), Convert.ToDecimal(txt_price.Text), Convert.ToDecimal(txt_price_sum.Text), maskedTextBox1.Text, maskedTextBox2.Text, txt_description.Text);

                        DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد ، آیا قصد ثبت فاکتور جدیدی دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            txt_customer.Text = string.Empty;
                            txt_factor_id.Text = string.Empty;
                            txt_price.Text = string.Empty;
                            txt_price_sum.Text = string.Empty;
                            txt_quantity.Text = string.Empty;
                            combo_price_type.Text = string.Empty;
                            combo_product_name.Text = string.Empty;
                            combo_type_factor.Text = string.Empty;
                            txt_description.Text = string.Empty;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else if (combo_type_factor.SelectedIndex == 1)
                    {
                       // MessageBox.Show("1");
                        int res = Factors.InsertFactorSell(Convert.ToInt32(txt_factor_id.Text), txt_customer.Text, combo_price_type.Text, id_product, Convert.ToDecimal(txt_quantity.Text), Convert.ToDecimal(txt_price.Text), Convert.ToDecimal(txt_price_sum.Text), maskedTextBox1.Text, maskedTextBox2.Text, txt_description.Text);
                        if (res == 1)
                        {
                            DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد ، آیا قصد ثبت فاکتور جدیدی دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                txt_customer.Text = string.Empty;
                                txt_factor_id.Text = string.Empty;
                                txt_price.Text = string.Empty;
                                txt_price_sum.Text = string.Empty;
                                txt_quantity.Text = string.Empty;
                                combo_price_type.Text = string.Empty;
                                combo_product_name.Text = string.Empty;
                                combo_type_factor.Text = string.Empty;
                                txt_description.Text = string.Empty;
                                combo_price_type.Text = string.Empty;
                                combo_product_name.Text = string.Empty;
                                combo_type_factor.Text = string.Empty;
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("مشکل در ذخیره داده ها لطفا با دقت اطلاعات را وارد نمایید", "گزارش");
                        }

                    }

                    //int rs = Cash.InsertCash(Convert.ToInt32(txt_factor_id.Text), Convert.ToDecimal(txt_price_sum.Text.Replace(",","")), Convert.ToDecimal(txt_price_sum.Text.Replace(",", "")), ds, maskedTextBox1.Text);
                }

            }
            catch
            {

            }
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

        private void combo_type_factor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_type_factor.Text == string.Empty)
            {
                errorProvider2.SetError(combo_type_factor, "نوع فاکتور نباید خالی باشد");
                errorProvider10.Clear();
            }
            else
            {
                errorProvider10.SetError(combo_type_factor, " ");
                errorProvider2.Clear();

                if (combo_type_factor.SelectedIndex == 0)
                {
                    int exist = Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text));
                    label12.Visible = false;
                    if (exist == 0)
                    {
                        errorProvider9.SetError(txt_factor_id, " ");
                        errorProvider1.Clear();
                    }
                    else if (exist == 1)
                    {
                        errorProvider1.SetError(txt_factor_id, "پیش فاکتور مورد نظر قبلا ثبت شده است لطفا با دقت شماره فاکتور را وارد نمایید");
                        errorProvider9.Clear();
                    }
                }
                else if (combo_type_factor.SelectedIndex == 1)
                {
                    label12.Visible = true;
                    label12.ForeColor = Color.Red;
                    int result = Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text));
                    if (result == 1)
                    {
                        label12.Text = dcweight.ToString();

                        errorProvider9.SetError(txt_factor_id, " ");
                        errorProvider1.Clear();

                        combo_product_name.Text = Products.SelectProduct(Convert.ToInt32(Factors.SelectFactorBuyProduct(Convert.ToInt32(txt_factor_id.Text))));

                        txt_price.Text = Factors.SelectFactorBuyPrice(Convert.ToInt32(txt_factor_id.Text));
                        string st = Factors.SelectFactorSellWeight(Convert.ToInt32(txt_factor_id.Text));
                        decimal sum;
                        if (st == string.Empty)
                        {
                            sum = 0;
                        }
                        else
                        {
                            sum = Convert.ToDecimal(st);
                        }
                        decimal weights = Convert.ToDecimal(Factors.SelectFactorBuyWeight(Convert.ToInt32(txt_factor_id.Text)));

                        if (sum < weights)
                        {
                            dcweight = weights - sum;
                        }
                        else
                        {
                            MessageBox.Show("فروش محصول بیش از خرید مورد نظر می باشد لطفا دقت فرمایید", "گزارش");
                            errorProvider2.SetError(combo_type_factor, "فروش محصول بیش از خرید مورد نظر می باشد لطفا دقت فرمایید");
                            errorProvider10.Clear();
                        }

                        
                    }
                    else
                    {
                        errorProvider1.SetError(txt_factor_id, "پیش فاکتور خرید جهت ثبت پیش فاکتور فورش وجود ندارد");
                        errorProvider9.Clear();
                    }
                }
            }
        }

        

        private void combo_price_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_price_type.Text == string.Empty)
                {
                    errorProvider3.SetError(combo_price_type, "نوع ارز نباید خالی باشد");
                    errorProvider11.Clear();
                }
                else
                {
                    errorProvider11.SetError(combo_price_type, " ");
                    errorProvider3.Clear();
                }
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void txt_customer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_customer.Text == string.Empty)
                {
                    errorProvider8.SetError(txt_customer, "طرف حساب نباید خالی باشد");
                    errorProvider16.Clear();
                }
                else
                {
                    errorProvider16.SetError(txt_customer, " ");
                    errorProvider8.Clear();
                }
            }
            catch
            {
               // MessageBox.Show(e.ToString());
            }
        }

        private void combo_product_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_product_name.Text == string.Empty)
                {
                    errorProvider4.SetError(combo_product_name, "نام کالا نباید خالی باشد");
                    errorProvider12.Clear();
                }
                else
                {
                    id_product = Products.SelectIdProduct(combo_product_name.Text);
                    //MessageBox.Show(id_product.ToString());
                    errorProvider12.SetError(combo_product_name, " ");
                    errorProvider4.Clear();
                }
            }
            catch
            {

            }
           
        }
    }
}
