namespace AppSoftWares
{
    partial class FrCast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCast));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cost_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
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
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider5.Icon")));
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            this.errorProvider6.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider6.Icon")));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(515, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "نوع :";
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(43, 186);
            this.txt_cost.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(458, 36);
            this.txt_cost.TabIndex = 2;
            this.txt_cost.TextChanged += new System.EventHandler(this.txt_cost_TextChanged);
            this.txt_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "مبلغ :";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(43, 282);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox2.Size = new System.Drawing.Size(458, 36);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 45;
            this.label11.Text = "تاریخ میلادی :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(43, 234);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.maskedTextBox1.Mask = "0000/00/00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(458, 36);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 44;
            this.label9.Text = "تاریخ شمسی :";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(43, 330);
            this.txt_description.Margin = new System.Windows.Forms.Padding(6);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(458, 111);
            this.txt_description.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 28);
            this.label2.TabIndex = 41;
            this.label2.Text = "توضیحات :";
            // 
            // txt_cost_id
            // 
            this.txt_cost_id.Location = new System.Drawing.Point(43, 90);
            this.txt_cost_id.Margin = new System.Windows.Forms.Padding(6);
            this.txt_cost_id.Name = "txt_cost_id";
            this.txt_cost_id.Size = new System.Drawing.Size(458, 36);
            this.txt_cost_id.TabIndex = 0;
            this.txt_cost_id.TextChanged += new System.EventHandler(this.txt_cost_id_TextChanged);
            this.txt_cost_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cost_id_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "شماره صندوق :";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(390, 450);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(111, 33);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "ثبت داده ها";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(232, 450);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(111, 33);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "انصراف";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Items.AddRange(new object[] {
            "واریز ",
            "برداشت"});
            this.comboBox1.Location = new System.Drawing.Point(43, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(458, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.UseSelectable = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrCast
            // 
            this.AcceptButton = this.metroButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton2;
            this.ClientSize = new System.Drawing.Size(661, 502);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cost_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrCast";
            this.Padding = new System.Windows.Forms.Padding(37, 129, 37, 43);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ثبت واریز ها و برداشت ها جهت هزینه های جاری";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrCast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cost_id;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBox1;
    }
}