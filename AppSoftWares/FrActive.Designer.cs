namespace AppSoftWares
{
    partial class FrActive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrActive));
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(463, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(40, 87);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PromptText = "کد سیستمی";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(497, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMark = "کد سیستمی";
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(391, 1);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox2.Lines = new string[0];
            this.textBox2.Location = new System.Drawing.Point(40, 130);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.PromptText = "کد فعال سازی";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.Size = new System.Drawing.Size(497, 107);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox2.UseSelectable = true;
            this.textBox2.WaterMark = "کد فعال سازی";
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(40, 248);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(497, 35);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "ثبت کد فعال سازی";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F);
            this.label3.Location = new System.Drawing.Point(52, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(477, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "لطفا از فروشنده نرم افزار بخواهید کد فعال سازی را برای شما ارسال کند با تشکر";
            // 
            // FrActive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrActive";
            this.Padding = new System.Windows.Forms.Padding(37, 111, 37, 37);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فعال سازی نرم افزار";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrActive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label3;
    }
}