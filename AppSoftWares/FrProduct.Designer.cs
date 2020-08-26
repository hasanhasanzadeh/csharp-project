namespace AppSoftWares
{
    partial class FrProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrProduct));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.txt_product_type = new MetroFramework.Controls.MetroTextBox();
            this.txt_product_name = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton1.Location = new System.Drawing.Point(212, 215);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 50);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "انصراف";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(368, 215);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(111, 50);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "ثبت داده ها";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // txt_product_type
            // 
            // 
            // 
            // 
            this.txt_product_type.CustomButton.Image = null;
            this.txt_product_type.CustomButton.Location = new System.Drawing.Point(373, 2);
            this.txt_product_type.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_type.CustomButton.Name = "";
            this.txt_product_type.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_product_type.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_product_type.CustomButton.TabIndex = 1;
            this.txt_product_type.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_product_type.CustomButton.UseSelectable = true;
            this.txt_product_type.CustomButton.Visible = false;
            this.txt_product_type.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_product_type.Lines = new string[0];
            this.txt_product_type.Location = new System.Drawing.Point(68, 152);
            this.txt_product_type.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_type.MaxLength = 32767;
            this.txt_product_type.Name = "txt_product_type";
            this.txt_product_type.PasswordChar = '\0';
            this.txt_product_type.PromptText = "نوع یا سایز محصول را وارد کنید";
            this.txt_product_type.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_product_type.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_product_type.SelectedText = "";
            this.txt_product_type.SelectionLength = 0;
            this.txt_product_type.SelectionStart = 0;
            this.txt_product_type.ShortcutsEnabled = true;
            this.txt_product_type.Size = new System.Drawing.Size(411, 40);
            this.txt_product_type.TabIndex = 1;
            this.txt_product_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_product_type.UseSelectable = true;
            this.txt_product_type.WaterMark = "نوع یا سایز محصول را وارد کنید";
            this.txt_product_type.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_product_type.WaterMarkFont = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_product_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_type_KeyPress);
            // 
            // txt_product_name
            // 
            // 
            // 
            // 
            this.txt_product_name.CustomButton.Image = null;
            this.txt_product_name.CustomButton.Location = new System.Drawing.Point(373, 2);
            this.txt_product_name.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.CustomButton.Name = "";
            this.txt_product_name.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_product_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_product_name.CustomButton.TabIndex = 1;
            this.txt_product_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_product_name.CustomButton.UseSelectable = true;
            this.txt_product_name.CustomButton.Visible = false;
            this.txt_product_name.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_product_name.Lines = new string[0];
            this.txt_product_name.Location = new System.Drawing.Point(68, 100);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(6);
            this.txt_product_name.MaxLength = 32767;
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.PasswordChar = '\0';
            this.txt_product_name.PromptText = "نام محصول را وارد کنید";
            this.txt_product_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_product_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_product_name.SelectedText = "";
            this.txt_product_name.SelectionLength = 0;
            this.txt_product_name.SelectionStart = 0;
            this.txt_product_name.ShortcutsEnabled = true;
            this.txt_product_name.Size = new System.Drawing.Size(411, 40);
            this.txt_product_name.TabIndex = 0;
            this.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_product_name.UseSelectable = true;
            this.txt_product_name.WaterMark = "نام محصول را وارد کنید";
            this.txt_product_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_product_name.WaterMarkFont = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_product_name.TextChanged += new System.EventHandler(this.txt_product_name_TextChanged);
            this.txt_product_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_product_name_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSoftWares.Properties.Resources.Package;
            this.pictureBox1.Location = new System.Drawing.Point(513, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // FrProduct
            // 
            this.AcceptButton = this.metroButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton1;
            this.ClientSize = new System.Drawing.Size(711, 325);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_product_type);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrProduct";
            this.Padding = new System.Windows.Forms.Padding(37, 129, 37, 43);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ایجاد محصولات جدید";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txt_product_type;
        private MetroFramework.Controls.MetroTextBox txt_product_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}