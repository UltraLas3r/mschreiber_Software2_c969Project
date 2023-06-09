﻿namespace mschreiber_Software2_c969Project
{
    partial class AddNewCustomer
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
            this.lbl_PhoneNumberValidation = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SaveCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_PhoneNumberValidation
            // 
            this.lbl_PhoneNumberValidation.AutoSize = true;
            this.lbl_PhoneNumberValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_PhoneNumberValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_PhoneNumberValidation.Location = new System.Drawing.Point(88, 477);
            this.lbl_PhoneNumberValidation.Name = "lbl_PhoneNumberValidation";
            this.lbl_PhoneNumberValidation.Size = new System.Drawing.Size(465, 40);
            this.lbl_PhoneNumberValidation.TabIndex = 29;
            this.lbl_PhoneNumberValidation.Text = "Phone number format shoul must follow the following format. \r\nFor example 555-555" +
    "-5555 (include dashes)\r\n";
            this.lbl_PhoneNumberValidation.Visible = false;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(201, 436);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(352, 26);
            this.txt_PhoneNumber.TabIndex = 27;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(201, 129);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(352, 26);
            this.txt_Address.TabIndex = 23;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(201, 72);
            this.txt_CustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(352, 26);
            this.txt_CustomerName.TabIndex = 22;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Name.Location = new System.Drawing.Point(15, 70);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(68, 25);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Address.Location = new System.Drawing.Point(12, 129);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(110, 25);
            this.lbl_Address.TabIndex = 18;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(15, 434);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(180, 25);
            this.lbl_PhoneNumber.TabIndex = 17;
            this.lbl_PhoneNumber.Text = "Phone Number";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(346, 554);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(252, 94);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SaveCustomer
            // 
            this.btn_SaveCustomer.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_SaveCustomer.Location = new System.Drawing.Point(35, 554);
            this.btn_SaveCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SaveCustomer.Name = "btn_SaveCustomer";
            this.btn_SaveCustomer.Size = new System.Drawing.Size(252, 94);
            this.btn_SaveCustomer.TabIndex = 28;
            this.btn_SaveCustomer.Text = "Add New Customer";
            this.btn_SaveCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveCustomer.Click += new System.EventHandler(this.btn_SaveNewCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 50);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add New Customer";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(201, 368);
            this.txt_Country.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(352, 26);
            this.txt_Country.TabIndex = 26;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Country.Location = new System.Drawing.Point(15, 369);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(110, 25);
            this.lbl_Country.TabIndex = 20;
            this.lbl_Country.Text = "Country";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_City.Location = new System.Drawing.Point(15, 204);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(68, 25);
            this.lbl_City.TabIndex = 19;
            this.lbl_City.Text = "City";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(201, 208);
            this.txt_City.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(352, 26);
            this.txt_City.TabIndex = 24;
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(201, 281);
            this.txt_PostalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(352, 26);
            this.txt_PostalCode.TabIndex = 25;
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_Post.Location = new System.Drawing.Point(15, 278);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(138, 25);
            this.lbl_Post.TabIndex = 33;
            this.lbl_Post.Text = "Post Code";
            // 
            // AddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(647, 682);
            this.Controls.Add(this.lbl_Post);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_PhoneNumberValidation);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_CustomerName);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveCustomer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddNewCustomer";
            this.Text = "Add New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PhoneNumberValidation;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SaveCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.Label lbl_Post;
    }
}