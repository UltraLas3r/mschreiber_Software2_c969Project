﻿namespace mschreiber_Software2_c969Project
{
    partial class MainHomePage
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreateAppointment = new System.Windows.Forms.Button();
            this.btn_ViewAppointments = new System.Windows.Forms.Button();
            this.btn_ModifyAppointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DeleteAppointment = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.lbl_UserLocationAndTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.radioButton1.Location = new System.Drawing.Point(1268, 159);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(233, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "View This week";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ViewThisWeekRadioButton);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.radioButton2.Location = new System.Drawing.Point(1268, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(247, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View This Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ViewThisMonthRadioButton);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 832);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upcoming Appointments";
            // 
            // btn_CreateAppointment
            // 
            this.btn_CreateAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_CreateAppointment.Location = new System.Drawing.Point(1301, 385);
            this.btn_CreateAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CreateAppointment.Name = "btn_CreateAppointment";
            this.btn_CreateAppointment.Size = new System.Drawing.Size(214, 111);
            this.btn_CreateAppointment.TabIndex = 6;
            this.btn_CreateAppointment.Text = "Create New Appointment";
            this.btn_CreateAppointment.UseVisualStyleBackColor = true;
            this.btn_CreateAppointment.Click += new System.EventHandler(this.CreateNewAppointment_Click);
            // 
            // btn_ViewAppointments
            // 
            this.btn_ViewAppointments.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_ViewAppointments.Location = new System.Drawing.Point(1268, 240);
            this.btn_ViewAppointments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewAppointments.Name = "btn_ViewAppointments";
            this.btn_ViewAppointments.Size = new System.Drawing.Size(268, 78);
            this.btn_ViewAppointments.TabIndex = 7;
            this.btn_ViewAppointments.Text = "View Appointments";
            this.btn_ViewAppointments.UseVisualStyleBackColor = true;
            this.btn_ViewAppointments.Click += new System.EventHandler(this.ViewAppointmentsButton_Click);
            // 
            // btn_ModifyAppointment
            // 
            this.btn_ModifyAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(1301, 524);
            this.btn_ModifyAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(214, 111);
            this.btn_ModifyAppointment.TabIndex = 8;
            this.btn_ModifyAppointment.Text = "Modify Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(1353, 1039);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(199, 65);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.MainHomePageExit);
            // 
            // btn_DeleteAppointment
            // 
            this.btn_DeleteAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_DeleteAppointment.Location = new System.Drawing.Point(1301, 666);
            this.btn_DeleteAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteAppointment.Name = "btn_DeleteAppointment";
            this.btn_DeleteAppointment.Size = new System.Drawing.Size(214, 110);
            this.btn_DeleteAppointment.TabIndex = 10;
            this.btn_DeleteAppointment.Text = "Delete Appointment";
            this.btn_DeleteAppointment.UseVisualStyleBackColor = true;
            this.btn_DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddCustomer.Location = new System.Drawing.Point(62, 959);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(156, 111);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(245, 959);
            this.btn_UpdateCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(156, 111);
            this.btn_UpdateCustomer.TabIndex = 12;
            this.btn_UpdateCustomer.Text = "Update Customer";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = true;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // lbl_UserLocationAndTime
            // 
            this.lbl_UserLocationAndTime.AutoSize = true;
            this.lbl_UserLocationAndTime.Location = new System.Drawing.Point(1077, 24);
            this.lbl_UserLocationAndTime.Name = "lbl_UserLocationAndTime";
            this.lbl_UserLocationAndTime.Size = new System.Drawing.Size(220, 20);
            this.lbl_UserLocationAndTime.TabIndex = 13;
            this.lbl_UserLocationAndTime.Text = "User Location, Date and Time";
            // 
            // MainHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1566, 1119);
            this.Controls.Add(this.lbl_UserLocationAndTime);
            this.Controls.Add(this.btn_UpdateCustomer);
            this.Controls.Add(this.btn_AddCustomer);
            this.Controls.Add(this.btn_DeleteAppointment);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ModifyAppointment);
            this.Controls.Add(this.btn_ViewAppointments);
            this.Controls.Add(this.btn_CreateAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainHomePage";
            this.Text = "Appointment Tracker Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreateAppointment;
        private System.Windows.Forms.Button btn_ViewAppointments;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_DeleteAppointment;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Label lbl_UserLocationAndTime;
    }
}