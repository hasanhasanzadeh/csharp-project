namespace AppSoftWares
{
    partial class FrEditCompany
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
            System.Windows.Forms.Label company_nameLabel;
            System.Windows.Forms.Label company_numberLabel;
            System.Windows.Forms.Label company_userLabel;
            System.Windows.Forms.Label company_addressLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrEditCompany));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.softWareDatabaseDataSet = new AppSoftWares.SoftWareDatabaseDataSet();
            this.company_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.company_TableTableAdapter = new AppSoftWares.SoftWareDatabaseDataSetTableAdapters.Company_TableTableAdapter();
            this.tableAdapterManager = new AppSoftWares.SoftWareDatabaseDataSetTableAdapters.TableAdapterManager();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.company_numberTextBox = new System.Windows.Forms.TextBox();
            this.company_userTextBox = new System.Windows.Forms.TextBox();
            this.company_addressTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            company_nameLabel = new System.Windows.Forms.Label();
            company_numberLabel = new System.Windows.Forms.Label();
            company_userLabel = new System.Windows.Forms.Label();
            company_addressLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.softWareDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Location = new System.Drawing.Point(753, 185);
            company_nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(78, 28);
            company_nameLabel.TabIndex = 5;
            company_nameLabel.Text = "نام شرکت :";
            // 
            // company_numberLabel
            // 
            company_numberLabel.AutoSize = true;
            company_numberLabel.Location = new System.Drawing.Point(753, 230);
            company_numberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            company_numberLabel.Name = "company_numberLabel";
            company_numberLabel.Size = new System.Drawing.Size(91, 28);
            company_numberLabel.TabIndex = 7;
            company_numberLabel.Text = "شماره تماس :";
            // 
            // company_userLabel
            // 
            company_userLabel.AutoSize = true;
            company_userLabel.Location = new System.Drawing.Point(753, 275);
            company_userLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            company_userLabel.Name = "company_userLabel";
            company_userLabel.Size = new System.Drawing.Size(99, 28);
            company_userLabel.TabIndex = 9;
            company_userLabel.Text = "نام مدیر عامل :";
            // 
            // company_addressLabel
            // 
            company_addressLabel.AutoSize = true;
            company_addressLabel.Location = new System.Drawing.Point(753, 320);
            company_addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            company_addressLabel.Name = "company_addressLabel";
            company_addressLabel.Size = new System.Drawing.Size(97, 28);
            company_addressLabel.TabIndex = 11;
            company_addressLabel.Text = "آدرس شرکت :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(753, 365);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(75, 28);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "توضیحات :";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(629, 414);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 49);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "ثبت داده ها";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton2.Location = new System.Drawing.Point(447, 414);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(6);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(114, 49);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "انصراف";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // softWareDatabaseDataSet
            // 
            this.softWareDatabaseDataSet.DataSetName = "SoftWareDatabaseDataSet";
            this.softWareDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // company_TableBindingSource
            // 
            this.company_TableBindingSource.DataMember = "Company_Table";
            this.company_TableBindingSource.DataSource = this.softWareDatabaseDataSet;
            // 
            // company_TableTableAdapter
            // 
            this.company_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cash_Ex_TableTableAdapter = null;
            this.tableAdapterManager.Cash_TableTableAdapter = null;
            this.tableAdapterManager.Company_TableTableAdapter = this.company_TableTableAdapter;
            this.tableAdapterManager.Driver_TableTableAdapter = null;
            this.tableAdapterManager.Enter_TableTableAdapter = null;
            this.tableAdapterManager.Exit_TableTableAdapter = null;
            this.tableAdapterManager.Factor_Buy_TableTableAdapter = null;
            this.tableAdapterManager.Factor_Sell_TableTableAdapter = null;
            this.tableAdapterManager.Product_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppSoftWares.SoftWareDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_TableTableAdapter = null;
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.company_TableBindingSource, "company_name", true));
            this.company_nameTextBox.Location = new System.Drawing.Point(77, 182);
            this.company_nameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(664, 36);
            this.company_nameTextBox.TabIndex = 6;
            // 
            // company_numberTextBox
            // 
            this.company_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.company_TableBindingSource, "company_number", true));
            this.company_numberTextBox.Location = new System.Drawing.Point(75, 227);
            this.company_numberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.company_numberTextBox.Name = "company_numberTextBox";
            this.company_numberTextBox.Size = new System.Drawing.Size(664, 36);
            this.company_numberTextBox.TabIndex = 8;
            // 
            // company_userTextBox
            // 
            this.company_userTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.company_TableBindingSource, "company_user", true));
            this.company_userTextBox.Location = new System.Drawing.Point(77, 272);
            this.company_userTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.company_userTextBox.Name = "company_userTextBox";
            this.company_userTextBox.Size = new System.Drawing.Size(664, 36);
            this.company_userTextBox.TabIndex = 10;
            // 
            // company_addressTextBox
            // 
            this.company_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.company_TableBindingSource, "company_address", true));
            this.company_addressTextBox.Location = new System.Drawing.Point(77, 317);
            this.company_addressTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.company_addressTextBox.Name = "company_addressTextBox";
            this.company_addressTextBox.Size = new System.Drawing.Size(664, 36);
            this.company_addressTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.company_TableBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(75, 362);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(664, 36);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSoftWares.Properties.Resources.Alpha_Dista_Icon_051000;
            this.pictureBox1.Location = new System.Drawing.Point(583, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 132);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrEditCompany
            // 
            this.AcceptButton = this.metroButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.metroButton2;
            this.ClientSize = new System.Drawing.Size(954, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(company_nameLabel);
            this.Controls.Add(this.company_nameTextBox);
            this.Controls.Add(company_numberLabel);
            this.Controls.Add(this.company_numberTextBox);
            this.Controls.Add(company_userLabel);
            this.Controls.Add(this.company_userTextBox);
            this.Controls.Add(company_addressLabel);
            this.Controls.Add(this.company_addressTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrEditCompany";
            this.Padding = new System.Windows.Forms.Padding(37, 129, 37, 43);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ویرایش اطلاعات شرکت";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrEditCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.softWareDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.company_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private SoftWareDatabaseDataSet softWareDatabaseDataSet;
        private System.Windows.Forms.BindingSource company_TableBindingSource;
        private SoftWareDatabaseDataSetTableAdapters.Company_TableTableAdapter company_TableTableAdapter;
        private SoftWareDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.TextBox company_numberTextBox;
        private System.Windows.Forms.TextBox company_userTextBox;
        private System.Windows.Forms.TextBox company_addressTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}