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
    
    public partial class FrEnter : MetroFramework.Forms.MetroForm
    {
        public FrEnter()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection();
        PersianCalendar pc = new PersianCalendar();
        int driver_id, product_id;
        Decimal th_weight, fa_weight,dc;

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    int rec = Factors.ExistFactorBuy(Convert.ToInt32(txt_factor_id.Text));
                   // MessageBox.Show(c.ToString());
                    if (rec == 1)
                    {

                    //driver_id = Convert.ToInt32(Driver.SelectIdDrivers(txt_number.Text));
                    
                    string f_Weight=string.Format(Enters.SelecBuySumWeight(Convert.ToInt32(txt_factor_id.Text)));
                    product_id = Enters.ReturnProductId(Convert.ToInt32(txt_factor_id.Text));
                    txt_product.Text = Products.SelectProduct(product_id);

                    int ce = Enters.ExistEnter(Convert.ToInt32(txt_factor_id.Text));
                    if (ce >= 1)
                    {
                        string h_weight = string.Format(Enters.SelecEnterSumWeight(Convert.ToInt32(txt_factor_id.Text)));
                        th_weight = Convert.ToDecimal(h_weight);
                        
                    }
                    else
                    {
                        th_weight = 0;
                    }
                   // th_weight = Convert.ToDecimal(h_weight);
                    //MessageBox.Show(h_weight);
                    fa_weight = Convert.ToDecimal(f_Weight);
                    dc = fa_weight - th_weight;

                        label8.Text = dc.ToString();
                        label8.ForeColor = Color.Red;

                        if (fa_weight < th_weight)
                        {
                            errorProvider1.SetError(txt_factor_id, "تناژ خریداری شده کمتر از فروش می باشد لطفا دقت فرمایید");
                            errorProvider7.Clear();
                        }
                        else if (fa_weight >= th_weight)
                        {
                            errorProvider7.SetError(txt_factor_id, " ");
                            errorProvider1.Clear();
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txt_factor_id, "شماره فاکتور ثبت نشده است");
                        errorProvider7.Clear();
                    }
                }
          
           
        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_product.Text == string.Empty)
                {
                    errorProvider4.SetError(txt_product, "نام محصول نباید خالی باشد");
                    errorProvider10.Clear();
                }
                else
                {
                    errorProvider10.SetError(txt_product, " ");
                    errorProvider4.Clear();
                    product_id = Products.SelectIdProduct(txt_product.Text);
                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }


        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_weight.Text == string.Empty)
                {
                    errorProvider3.SetError(txt_weight, "وزن نباید خالی باشد");
                    errorProvider9.Clear();
                }
                else
                {
                    decimal cr = Convert.ToDecimal(label8.Text);
                    decimal txtweig = Convert.ToDecimal(txt_weight.Text);

                    if (txtweig <= cr)
                    {
                        errorProvider9.SetError(txt_weight, " ");
                        errorProvider3.Clear();
                    }
                    else
                    {
                        errorProvider3.SetError(txt_weight, "محصول مورد نظر قبلا بارگیری شده است");
                        errorProvider9.Clear();
                    }

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
                errorProvider1.SetError(txt_factor_id, "شماره فاکتور نباید خالی باشد");
                errorProvider7.Clear();
            }
            if (driver_id == 0)
            {
                errorProvider2.SetError(txt_number, "شماره ماشین نباید خالی باشد");
                errorProvider8.Clear();
            }
            if (product_id == 0)
            {
                errorProvider4.SetError(txt_product, "نام محصول نباید خالی باشد");
                errorProvider10.Clear();
            }
            if (txt_weight.Text == string.Empty)
            {
                errorProvider3.SetError(txt_weight, "وزن نباید خالی باشد");
                errorProvider9.Clear();
            }
            else if (errorProvider1.GetError(txt_factor_id).Length < 1 &&
                errorProvider4.GetError(txt_product).Length < 1 && 
                errorProvider2.GetError(txt_number).Length < 1 && 
                errorProvider3.GetError(txt_weight).Length < 1)
            {
                int result = Enters.InsertEnter(Convert.ToInt32(txt_factor_id.Text), driver_id, Convert.ToDecimal(txt_weight.Text), product_id, txt_cotash.Text, txt_barname.Text, txt_description.Text, maskedTextBox1.Text, maskedTextBox2.Text);
                if (result == 1)
                {
                    DialogResult dr = MessageBox.Show("اطلاعات با موفقیت ثبت شد آیا قصد ثبت اطلاعات دیگری دارید؟", "گزارش", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        txt_barname.Text = string.Empty;
                        txt_cotash.Text = string.Empty;
                        txt_factor_id.Text = string.Empty;
                        txt_number.Text = string.Empty;
                        txt_weight.Text = string.Empty;
                        txt_product.Text = string.Empty;
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
                
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                e.Handled = false;
            }
        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_number.Text == string.Empty)
                {
                    errorProvider2.SetError(txt_number, "شماره ماشین نباید خالی باشد");
                    errorProvider8.Clear();
                }
                else
                {
                    int c = Driver.ExistDriver(txt_number.Text);
                    if (c == 1)
                    {
                        errorProvider8.SetError(txt_number, " ");
                        errorProvider2.Clear();
                        driver_id = Convert.ToInt32(Driver.SelectIdDrivers(txt_number.Text));
                    }
                    else
                    {
                        errorProvider2.SetError(txt_number, "شماره ماشین ثبت نشده است");
                        errorProvider8.Clear();
                        driver_id = 0;
                    }

                }
            }
            catch
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void FrEnter_Load(object sender, EventArgs e)
        {
           
            try
            {
                maskedTextBox2.Text = DateTime.Now.ToString("MM/dd/yyyy");
                maskedTextBox1.Text = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("0,0") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("0,0");


                con.ConnectionString = @"Data Source = . ; Initial Catalog = SoftWareDatabase ; Integrated Security = true;";
                SqlCommand cmd = new SqlCommand("select truck_number from Driver_Table", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    mycollection.Add(dr.GetString(0));
                }
                txt_number.AutoCompleteCustomSource = mycollection;
                con.Close(); 

                SqlCommand cmds = new SqlCommand("select product_name from Product_Table", con);
                con.Open();
                SqlDataReader drs = cmds.ExecuteReader();
                AutoCompleteStringCollection mycollections = new AutoCompleteStringCollection();
                while (drs.Read())
                {
                    mycollections.Add(drs.GetString(0));
                }
                txt_product.AutoCompleteCustomSource = mycollections;
                con.Close();

            }
            catch
            {

            }
        }
    }
}
