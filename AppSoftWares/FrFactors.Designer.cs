namespace AppSoftWares
{
    partial class FrFactors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrFactors));
            this.combo_price_type = new MetroFramework.Controls.MetroComboBox();
            this.txt_factor_id = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_quantity = new MetroFramework.Controls.MetroTextBox();
            this.txt_price = new MetroFramework.Controls.MetroTextBox();
            this.txt_price_sum = new MetroFramework.Controls.MetroTextBox();
            this.txt_customer = new MetroFramework.Controls.MetroTextBox();
            this.txt_description = new MetroFramework.Controls.MetroTextBox();
            this.productTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softWareDatabaseDataSet = new AppSoftWares.SoftWareDatabaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_type_factor = new MetroFramework.Controls.MetroComboBox();
            this.product_TableTableAdapter = new AppSoftWares.SoftWareDatabaseDataSetTableAdapters.Product_TableTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider11 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider12 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider13 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider14 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider15 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider16 = new System.Windows.Forms.ErrorProvider(this.components);
            this.combo_product_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softWareDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider16)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_price_type
            // 
            this.combo_price_type.FormattingEnabled = true;
            this.combo_price_type.ItemHeight = 23;
            this.combo_price_type.Items.AddRange(new object[] {
            "تومان",
            "دلار"});
            this.combo_price_type.Location = new System.Drawing.Point(43, 88);
            this.combo_price_type.Margin = new System.Windows.Forms.Padding(6);
            this.combo_price_type.Name = "combo_price_type";
            this.combo_price_type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combo_price_type.Size = new System.Drawing.Size(333, 29);
            this.combo_price_type.TabIndex = 0;
            this.combo_price_type.UseSelectable = true;
            this.combo_price_type.SelectedIndexChanged += new System.EventHandler(this.combo_price_type_SelectedIndexChanged);
            // 
            // txt_factor_id
            // 
            // 
            // 
            // 
            this.txt_factor_id.CustomButton.Image = null;
            this.txt_factor_id.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txt_factor_id.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_factor_id.CustomButton.Name = "";
            this.txt_factor_id.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_factor_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_factor_id.CustomButton.TabIndex = 1;
            this.txt_factor_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_factor_id.CustomButton.UseSelectable = true;
            this.txt_factor_id.CustomButton.Visible = false;
            this.txt_factor_id.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_factor_id.Lines = new string[0];
            this.txt_factor_id.Location = new System.Drawing.Point(542, 129);
            this.txt_factor_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_factor_id.MaxLength = 32767;
            this.txt_factor_id.Name = "txt_factor_id";
            this.txt_factor_id.PasswordChar = '\0';
            this.txt_factor_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_factor_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_factor_id.SelectedText = "";
            this.txt_factor_id.SelectionLength = 0;
            this.txt_factor_id.SelectionStart = 0;
            this.txt_factor_id.ShortcutsEnabled = true;
            this.txt_factor_id.Size = new System.Drawing.Size(323, 35);
            this.txt_factor_id.TabIndex = 1;
            this.txt_factor_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_factor_id.UseSelectable = true;
            this.txt_factor_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_factor_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_factor_id.TextChanged += new System.EventHandler(this.txt_factor_id_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(43, 412);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(118, 37);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "انصراف";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(258, 412);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(118, 37);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "ذخیره داده ها";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(43, 231);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox2.Size = new System.Drawing.Size(333, 36);
            this.maskedTextBox2.TabIndex = 26;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(43, 177);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(333, 36);
            this.maskedTextBox1.TabIndex = 25;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_quantity
            // 
            // 
            // 
            // 
            this.txt_quantity.CustomButton.Image = null;
            this.txt_quantity.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txt_quantity.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_quantity.CustomButton.Name = "";
            this.txt_quantity.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantity.CustomButton.TabIndex = 1;
            this.txt_quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantity.CustomButton.UseSelectable = true;
            this.txt_quantity.CustomButton.Visible = false;
            this.txt_quantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_quantity.Lines = new string[0];
            this.txt_quantity.Location = new System.Drawing.Point(542, 182);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(6);
            this.txt_quantity.MaxLength = 32767;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.SelectionLength = 0;
            this.txt_quantity.SelectionStart = 0;
            this.txt_quantity.ShortcutsEnabled = true;
            this.txt_quantity.Size = new System.Drawing.Size(323, 35);
            this.txt_quantity.TabIndex = 27;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_quantity.UseSelectable = true;
            this.txt_quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            // 
            // txt_price
            // 
            // 
            // 
            // 
            this.txt_price.CustomButton.Image = null;
            this.txt_price.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txt_price.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price.CustomButton.Name = "";
            this.txt_price.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price.CustomButton.TabIndex = 1;
            this.txt_price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price.CustomButton.UseSelectable = true;
            this.txt_price.CustomButton.Visible = false;
            this.txt_price.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_price.Lines = new string[0];
            this.txt_price.Location = new System.Drawing.Point(542, 235);
            this.txt_price.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price.MaxLength = 32767;
            this.txt_price.Name = "txt_price";
            this.txt_price.PasswordChar = '\0';
            this.txt_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price.SelectedText = "";
            this.txt_price.SelectionLength = 0;
            this.txt_price.SelectionStart = 0;
            this.txt_price.ShortcutsEnabled = true;
            this.txt_price.Size = new System.Drawing.Size(323, 35);
            this.txt_price.TabIndex = 28;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_price.UseSelectable = true;
            this.txt_price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // txt_price_sum
            // 
            // 
            // 
            // 
            this.txt_price_sum.CustomButton.Image = null;
            this.txt_price_sum.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txt_price_sum.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price_sum.CustomButton.Name = "";
            this.txt_price_sum.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_price_sum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_price_sum.CustomButton.TabIndex = 1;
            this.txt_price_sum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_price_sum.CustomButton.UseSelectable = true;
            this.txt_price_sum.CustomButton.Visible = false;
            this.txt_price_sum.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_price_sum.Lines = new string[0];
            this.txt_price_sum.Location = new System.Drawing.Point(542, 288);
            this.txt_price_sum.Margin = new System.Windows.Forms.Padding(6);
            this.txt_price_sum.MaxLength = 32767;
            this.txt_price_sum.Name = "txt_price_sum";
            this.txt_price_sum.PasswordChar = '\0';
            this.txt_price_sum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_price_sum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_price_sum.SelectedText = "";
            this.txt_price_sum.SelectionLength = 0;
            this.txt_price_sum.SelectionStart = 0;
            this.txt_price_sum.ShortcutsEnabled = true;
            this.txt_price_sum.Size = new System.Drawing.Size(323, 35);
            this.txt_price_sum.TabIndex = 29;
            this.txt_price_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_price_sum.UseSelectable = true;
            this.txt_price_sum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_price_sum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_price_sum.TextChanged += new System.EventHandler(this.txt_price_sum_TextChanged);
            this.txt_price_sum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_sum_KeyPress);
            // 
            // txt_customer
            // 
            // 
            // 
            // 
            this.txt_customer.CustomButton.Image = null;
            this.txt_customer.CustomButton.Location = new System.Drawing.Point(289, 1);
            this.txt_customer.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_customer.CustomButton.Name = "";
            this.txt_customer.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txt_customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_customer.CustomButton.TabIndex = 1;
            this.txt_customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_customer.CustomButton.UseSelectable = true;
            this.txt_customer.CustomButton.Visible = false;
            this.txt_customer.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_customer.Lines = new string[0];
            this.txt_customer.Location = new System.Drawing.Point(542, 341);
            this.txt_customer.Margin = new System.Windows.Forms.Padding(6);
            this.txt_customer.MaxLength = 32767;
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.PasswordChar = '\0';
            this.txt_customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_customer.SelectedText = "";
            this.txt_customer.SelectionLength = 0;
            this.txt_customer.SelectionStart = 0;
            this.txt_customer.ShortcutsEnabled = true;
            this.txt_customer.Size = new System.Drawing.Size(323, 35);
            this.txt_customer.TabIndex = 30;
            this.txt_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_customer.UseSelectable = true;
            this.txt_customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_customer.TextChanged += new System.EventHandler(this.txt_customer_TextChanged);
            // 
            // txt_description
            // 
            // 
            // 
            // 
            this.txt_description.CustomButton.Image = null;
            this.txt_description.CustomButton.Location = new System.Drawing.Point(247, 2);
            this.txt_description.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_description.CustomButton.Name = "";
            this.txt_description.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txt_description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_description.CustomButton.TabIndex = 1;
            this.txt_description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_description.CustomButton.UseSelectable = true;
            this.txt_description.CustomButton.Visible = false;
            this.txt_description.Lines = new string[0];
            this.txt_description.Location = new System.Drawing.Point(43, 294);
            this.txt_description.Margin = new System.Windows.Forms.Padding(6);
            this.txt_description.MaxLength = 32767;
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_description.SelectedText = "";
            this.txt_description.SelectionLength = 0;
            this.txt_description.SelectionStart = 0;
            this.txt_description.ShortcutsEnabled = true;
            this.txt_description.Size = new System.Drawing.Size(333, 88);
            this.txt_description.TabIndex = 31;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_description.UseSelectable = true;
            this.txt_description.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_description.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // productTableBindingSource
            // 
            this.productTableBindingSource.DataMember = "Product_Table";
            this.productTableBindingSource.DataSource = this.softWareDatabaseDataSet;
            // 
            // softWareDatabaseDataSet
            // 
            this.softWareDatabaseDataSet.DataSetName = "SoftWareDatabaseDataSet";
            this.softWareDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSoftWares.Properties.Resources.Registration;
            this.pictureBox1.Location = new System.Drawing.Point(753, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // combo_type_factor
            // 
            this.combo_type_factor.FormattingEnabled = true;
            this.combo_type_factor.ItemHeight = 23;
            this.combo_type_factor.Items.AddRange(new object[] {
            "خرید",
            "فروش"});
            this.combo_type_factor.Location = new System.Drawing.Point(542, 395);
            this.combo_type_factor.Margin = new System.Windows.Forms.Padding(6);
            this.combo_type_factor.Name = "combo_type_factor";
            this.combo_type_factor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combo_type_factor.Size = new System.Drawing.Size(323, 29);
            this.combo_type_factor.TabIndex = 34;
            this.combo_type_factor.UseSelectable = true;
            this.combo_type_factor.SelectedIndexChanged += new System.EventHandler(this.combo_type_factor_SelectedIndexChanged);
            // 
            // product_TableTableAdapter
            // 
            this.product_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(385, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 45;
            this.label11.Text = "تاریخ میلادی :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 28);
            this.label10.TabIndex = 44;
            this.label10.Text = "توضیحات :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "تاریخ شمسی :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(868, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 42;
            this.label8.Text = "نام طرف حساب :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(868, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "قیمت کل :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "قیمت واحد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(868, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 28);
            this.label5.TabIndex = 39;
            this.label5.Text = "تناژ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "نام کالا :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 37;
            this.label3.Text = "نوع ارز :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(868, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "نوع فاکتور :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(868, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "شماره فاکتور :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 28);
            this.label12.TabIndex = 46;
            this.label12.Text = "-";
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            this.errorProvider10.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider10.Icon")));
            // 
            // errorProvider11
            // 
            this.errorProvider11.ContainerControl = this;
            this.errorProvider11.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider11.Icon")));
            // 
            // errorProvider12
            // 
            this.errorProvider12.ContainerControl = this;
            this.errorProvider12.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider12.Icon")));
            // 
            // errorProvider13
            // 
            this.errorProvider13.ContainerControl = this;
            this.errorProvider13.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider13.Icon")));
            // 
            // errorProvider14
            // 
            this.errorProvider14.ContainerControl = this;
            this.errorProvider14.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider14.Icon")));
            // 
            // errorProvider15
            // 
            this.errorProvider15.ContainerControl = this;
            this.errorProvider15.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider15.Icon")));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            this.errorProvider9.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider9.Icon")));
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider16
            // 
            this.errorProvider16.ContainerControl = this;
            this.errorProvider16.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider16.Icon")));
            // 
            // combo_product_name
            // 
            this.combo_product_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_product_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combo_product_name.Location = new System.Drawing.Point(43, 126);
            this.combo_product_name.Name = "combo_product_name";
            this.combo_product_name.Size = new System.Drawing.Size(333, 36);
            this.combo_product_name.TabIndex = 47;
            this.combo_product_name.TextChanged += new System.EventHandler(this.combo_product_name_TextChanged);
            // 
            // FrFactors
            // 
            this.AcceptButton = this.metroButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton1;
            this.ClientSize = new System.Drawing.Size(1002, 473);
            this.Controls.Add(this.combo_product_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_type_factor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.txt_price_sum);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_factor_id);
            this.Controls.Add(this.combo_price_type);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrFactors";
            this.Padding = new System.Windows.Forms.Padding(37, 129, 37, 43);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت پیش فاکتورها";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrFactors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softWareDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox combo_price_type;
        private MetroFramework.Controls.MetroTextBox txt_factor_id;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private MetroFramework.Controls.MetroTextBox txt_quantity;
        private MetroFramework.Controls.MetroTextBox txt_price;
        private MetroFramework.Controls.MetroTextBox txt_price_sum;
        private MetroFramework.Controls.MetroTextBox txt_customer;
        private MetroFramework.Controls.MetroTextBox txt_description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroComboBox combo_type_factor;
        private SoftWareDatabaseDataSet softWareDatabaseDataSet;
        private System.Windows.Forms.BindingSource productTableBindingSource;
        private SoftWareDatabaseDataSetTableAdapters.Product_TableTableAdapter product_TableTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.ErrorProvider errorProvider11;
        private System.Windows.Forms.ErrorProvider errorProvider12;
        private System.Windows.Forms.ErrorProvider errorProvider13;
        private System.Windows.Forms.ErrorProvider errorProvider14;
        private System.Windows.Forms.ErrorProvider errorProvider15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider16;
        private System.Windows.Forms.TextBox combo_product_name;
    }
}