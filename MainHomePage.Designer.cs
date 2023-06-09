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
            this.rb_ViewWeek = new System.Windows.Forms.RadioButton();
            this.rb_ViewMonth = new System.Windows.Forms.RadioButton();
            this.dgv_AppointmentGrid = new System.Windows.Forms.DataGridView();
            this.lbl_Appointments = new System.Windows.Forms.Label();
            this.btn_AddNewAppointment = new System.Windows.Forms.Button();
            this.btn_ModifyAppointment = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_DeleteAppointment = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_ModifyCustomer = new System.Windows.Forms.Button();
            this.tab_Appointment = new System.Windows.Forms.TabControl();
            this.Appointments = new System.Windows.Forms.TabPage();
            this.lbl_NoMatch = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_AppointmentSearch = new System.Windows.Forms.TextBox();
            this.rb_ViewAll = new System.Windows.Forms.RadioButton();
            this.Customers = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CustSearch = new System.Windows.Forms.Button();
            this.tb_CustSearch = new System.Windows.Forms.TextBox();
            this.btn_AllCustomers = new System.Windows.Forms.Button();
            this.btn_ViewCustomersWithAppointments = new System.Windows.Forms.Button();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.DGV_Customers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Reports = new System.Windows.Forms.TabPage();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.dgv_Reports = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentGrid)).BeginInit();
            this.tab_Appointment.SuspendLayout();
            this.Appointments.SuspendLayout();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).BeginInit();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_ViewWeek
            // 
            this.rb_ViewWeek.AutoSize = true;
            this.rb_ViewWeek.Checked = true;
            this.rb_ViewWeek.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.rb_ViewWeek.Location = new System.Drawing.Point(508, 172);
            this.rb_ViewWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_ViewWeek.Name = "rb_ViewWeek";
            this.rb_ViewWeek.Size = new System.Drawing.Size(233, 29);
            this.rb_ViewWeek.TabIndex = 0;
            this.rb_ViewWeek.TabStop = true;
            this.rb_ViewWeek.Text = "View This week";
            this.rb_ViewWeek.UseVisualStyleBackColor = true;
            this.rb_ViewWeek.CheckedChanged += new System.EventHandler(this.ViewThisWeekRadioButton);
            // 
            // rb_ViewMonth
            // 
            this.rb_ViewMonth.AutoSize = true;
            this.rb_ViewMonth.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.rb_ViewMonth.Location = new System.Drawing.Point(508, 131);
            this.rb_ViewMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_ViewMonth.Name = "rb_ViewMonth";
            this.rb_ViewMonth.Size = new System.Drawing.Size(247, 29);
            this.rb_ViewMonth.TabIndex = 1;
            this.rb_ViewMonth.Text = "View This Month";
            this.rb_ViewMonth.UseVisualStyleBackColor = true;
            this.rb_ViewMonth.CheckedChanged += new System.EventHandler(this.ViewThisMonthRadioButton);
            // 
            // dgv_AppointmentGrid
            // 
            this.dgv_AppointmentGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AppointmentGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_AppointmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AppointmentGrid.Location = new System.Drawing.Point(15, 276);
            this.dgv_AppointmentGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_AppointmentGrid.Name = "dgv_AppointmentGrid";
            this.dgv_AppointmentGrid.ReadOnly = true;
            this.dgv_AppointmentGrid.RowHeadersWidth = 51;
            this.dgv_AppointmentGrid.RowTemplate.Height = 24;
            this.dgv_AppointmentGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AppointmentGrid.Size = new System.Drawing.Size(1200, 366);
            this.dgv_AppointmentGrid.TabIndex = 4;
            // 
            // lbl_Appointments
            // 
            this.lbl_Appointments.AutoSize = true;
            this.lbl_Appointments.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.lbl_Appointments.Location = new System.Drawing.Point(27, 19);
            this.lbl_Appointments.Name = "lbl_Appointments";
            this.lbl_Appointments.Size = new System.Drawing.Size(631, 50);
            this.lbl_Appointments.TabIndex = 5;
            this.lbl_Appointments.Text = "Upcoming Appointments";
            // 
            // btn_AddNewAppointment
            // 
            this.btn_AddNewAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddNewAppointment.Location = new System.Drawing.Point(15, 95);
            this.btn_AddNewAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddNewAppointment.Name = "btn_AddNewAppointment";
            this.btn_AddNewAppointment.Size = new System.Drawing.Size(214, 111);
            this.btn_AddNewAppointment.TabIndex = 6;
            this.btn_AddNewAppointment.Text = "Add New Appointment";
            this.btn_AddNewAppointment.UseVisualStyleBackColor = true;
            this.btn_AddNewAppointment.Click += new System.EventHandler(this.CreateNewAppointment_Click);
            // 
            // btn_ModifyAppointment
            // 
            this.btn_ModifyAppointment.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_ModifyAppointment.Location = new System.Drawing.Point(235, 95);
            this.btn_ModifyAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyAppointment.Name = "btn_ModifyAppointment";
            this.btn_ModifyAppointment.Size = new System.Drawing.Size(214, 111);
            this.btn_ModifyAppointment.TabIndex = 8;
            this.btn_ModifyAppointment.Text = "Update Appointment";
            this.btn_ModifyAppointment.UseVisualStyleBackColor = true;
            this.btn_ModifyAppointment.Click += new System.EventHandler(this.btn_ModifyAppointment_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(1053, 752);
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
            this.btn_DeleteAppointment.Location = new System.Drawing.Point(1001, 198);
            this.btn_DeleteAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteAppointment.Name = "btn_DeleteAppointment";
            this.btn_DeleteAppointment.Size = new System.Drawing.Size(214, 71);
            this.btn_DeleteAppointment.TabIndex = 10;
            this.btn_DeleteAppointment.Text = "Delete Appointment";
            this.btn_DeleteAppointment.UseVisualStyleBackColor = true;
            this.btn_DeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_AddCustomer.Location = new System.Drawing.Point(410, 58);
            this.btn_AddCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(219, 68);
            this.btn_AddCustomer.TabIndex = 11;
            this.btn_AddCustomer.Text = "Add Customer";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            this.btn_AddCustomer.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // btn_ModifyCustomer
            // 
            this.btn_ModifyCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_ModifyCustomer.Location = new System.Drawing.Point(694, 58);
            this.btn_ModifyCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ModifyCustomer.Name = "btn_ModifyCustomer";
            this.btn_ModifyCustomer.Size = new System.Drawing.Size(219, 68);
            this.btn_ModifyCustomer.TabIndex = 12;
            this.btn_ModifyCustomer.Text = "Update Customer";
            this.btn_ModifyCustomer.UseVisualStyleBackColor = true;
            this.btn_ModifyCustomer.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // tab_Appointment
            // 
            this.tab_Appointment.Controls.Add(this.Appointments);
            this.tab_Appointment.Controls.Add(this.Customers);
            this.tab_Appointment.Controls.Add(this.Reports);
            this.tab_Appointment.Location = new System.Drawing.Point(14, 35);
            this.tab_Appointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Appointment.Name = "tab_Appointment";
            this.tab_Appointment.SelectedIndex = 0;
            this.tab_Appointment.Size = new System.Drawing.Size(1242, 686);
            this.tab_Appointment.TabIndex = 15;
            // 
            // Appointments
            // 
            this.Appointments.BackColor = System.Drawing.Color.Gray;
            this.Appointments.Controls.Add(this.lbl_NoMatch);
            this.Appointments.Controls.Add(this.btn_Search);
            this.Appointments.Controls.Add(this.txt_AppointmentSearch);
            this.Appointments.Controls.Add(this.rb_ViewAll);
            this.Appointments.Controls.Add(this.lbl_Appointments);
            this.Appointments.Controls.Add(this.btn_AddNewAppointment);
            this.Appointments.Controls.Add(this.btn_ModifyAppointment);
            this.Appointments.Controls.Add(this.btn_DeleteAppointment);
            this.Appointments.Controls.Add(this.dgv_AppointmentGrid);
            this.Appointments.Controls.Add(this.rb_ViewWeek);
            this.Appointments.Controls.Add(this.rb_ViewMonth);
            this.Appointments.Location = new System.Drawing.Point(4, 29);
            this.Appointments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Appointments.Name = "Appointments";
            this.Appointments.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Appointments.Size = new System.Drawing.Size(1234, 653);
            this.Appointments.TabIndex = 0;
            this.Appointments.Text = "Appointments";
            // 
            // lbl_NoMatch
            // 
            this.lbl_NoMatch.AutoSize = true;
            this.lbl_NoMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_NoMatch.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.lbl_NoMatch.Location = new System.Drawing.Point(758, 229);
            this.lbl_NoMatch.Name = "lbl_NoMatch";
            this.lbl_NoMatch.Size = new System.Drawing.Size(166, 30);
            this.lbl_NoMatch.TabIndex = 30;
            this.lbl_NoMatch.Text = "No Match!\r\n";
            this.lbl_NoMatch.Visible = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_Search.Location = new System.Drawing.Point(15, 229);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(123, 36);
            this.btn_Search.TabIndex = 14;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_SearchAppointments_Click);
            // 
            // txt_AppointmentSearch
            // 
            this.txt_AppointmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_AppointmentSearch.Location = new System.Drawing.Point(153, 229);
            this.txt_AppointmentSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_AppointmentSearch.Name = "txt_AppointmentSearch";
            this.txt_AppointmentSearch.Size = new System.Drawing.Size(588, 35);
            this.txt_AppointmentSearch.TabIndex = 13;
            this.txt_AppointmentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AppointmentSearchTextBox_KeyPress);
            // 
            // rb_ViewAll
            // 
            this.rb_ViewAll.AutoSize = true;
            this.rb_ViewAll.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.rb_ViewAll.Location = new System.Drawing.Point(508, 91);
            this.rb_ViewAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ViewAll.Name = "rb_ViewAll";
            this.rb_ViewAll.Size = new System.Drawing.Size(331, 29);
            this.rb_ViewAll.TabIndex = 11;
            this.rb_ViewAll.TabStop = true;
            this.rb_ViewAll.Text = "View All Appointments";
            this.rb_ViewAll.UseVisualStyleBackColor = true;
            this.rb_ViewAll.CheckedChanged += new System.EventHandler(this.rb_ViewAll_CheckedChanged);
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Gray;
            this.Customers.Controls.Add(this.label3);
            this.Customers.Controls.Add(this.btn_CustSearch);
            this.Customers.Controls.Add(this.tb_CustSearch);
            this.Customers.Controls.Add(this.btn_AllCustomers);
            this.Customers.Controls.Add(this.btn_ViewCustomersWithAppointments);
            this.Customers.Controls.Add(this.btn_DeleteCustomer);
            this.Customers.Controls.Add(this.DGV_Customers);
            this.Customers.Controls.Add(this.label2);
            this.Customers.Controls.Add(this.btn_AddCustomer);
            this.Customers.Controls.Add(this.btn_ModifyCustomer);
            this.Customers.Location = new System.Drawing.Point(4, 29);
            this.Customers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Customers.Size = new System.Drawing.Size(1234, 653);
            this.Customers.TabIndex = 1;
            this.Customers.Text = "Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14F);
            this.label3.Location = new System.Drawing.Point(924, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 30);
            this.label3.TabIndex = 31;
            this.label3.Text = "No Match!\r\n";
            this.label3.Visible = false;
            // 
            // btn_CustSearch
            // 
            this.btn_CustSearch.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.btn_CustSearch.Location = new System.Drawing.Point(192, 140);
            this.btn_CustSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CustSearch.Name = "btn_CustSearch";
            this.btn_CustSearch.Size = new System.Drawing.Size(123, 36);
            this.btn_CustSearch.TabIndex = 19;
            this.btn_CustSearch.Text = "Search";
            this.btn_CustSearch.UseVisualStyleBackColor = true;
            this.btn_CustSearch.Click += new System.EventHandler(this.btn_CustSearch_Click);
            this.btn_CustSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CustSearch_KeyPress);
            // 
            // tb_CustSearch
            // 
            this.tb_CustSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CustSearch.Location = new System.Drawing.Point(330, 140);
            this.tb_CustSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_CustSearch.Name = "tb_CustSearch";
            this.tb_CustSearch.Size = new System.Drawing.Size(588, 35);
            this.tb_CustSearch.TabIndex = 18;
            this.tb_CustSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CustSearch_KeyPress);
            // 
            // btn_AllCustomers
            // 
            this.btn_AllCustomers.Location = new System.Drawing.Point(15, 572);
            this.btn_AllCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AllCustomers.Name = "btn_AllCustomers";
            this.btn_AllCustomers.Size = new System.Drawing.Size(155, 56);
            this.btn_AllCustomers.TabIndex = 17;
            this.btn_AllCustomers.Text = "All Customers";
            this.btn_AllCustomers.UseVisualStyleBackColor = true;
            this.btn_AllCustomers.Click += new System.EventHandler(this.btn_AllCustomers_Click);
            // 
            // btn_ViewCustomersWithAppointments
            // 
            this.btn_ViewCustomersWithAppointments.Location = new System.Drawing.Point(15, 192);
            this.btn_ViewCustomersWithAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ViewCustomersWithAppointments.Name = "btn_ViewCustomersWithAppointments";
            this.btn_ViewCustomersWithAppointments.Size = new System.Drawing.Size(155, 56);
            this.btn_ViewCustomersWithAppointments.TabIndex = 16;
            this.btn_ViewCustomersWithAppointments.Text = "Customers With Appointments";
            this.btn_ViewCustomersWithAppointments.UseVisualStyleBackColor = true;
            this.btn_ViewCustomersWithAppointments.Click += new System.EventHandler(this.btn_GetCustomerInfo_Click);
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.Font = new System.Drawing.Font("OCR A Extended", 11F);
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(971, 58);
            this.btn_DeleteCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(245, 68);
            this.btn_DeleteCustomer.TabIndex = 15;
            this.btn_DeleteCustomer.Text = "Delete Customer";
            this.btn_DeleteCustomer.UseVisualStyleBackColor = true;
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // DGV_Customers
            // 
            this.DGV_Customers.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customers.Location = new System.Drawing.Point(192, 192);
            this.DGV_Customers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_Customers.Name = "DGV_Customers";
            this.DGV_Customers.ReadOnly = true;
            this.DGV_Customers.RowHeadersWidth = 62;
            this.DGV_Customers.RowTemplate.Height = 28;
            this.DGV_Customers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Customers.Size = new System.Drawing.Size(1024, 436);
            this.DGV_Customers.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customers";
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.Gray;
            this.Reports.Controls.Add(this.lbl_4);
            this.Reports.Controls.Add(this.lbl_3);
            this.Reports.Controls.Add(this.lbl_2);
            this.Reports.Controls.Add(this.lbl_1);
            this.Reports.Controls.Add(this.dgv_Reports);
            this.Reports.Controls.Add(this.button3);
            this.Reports.Controls.Add(this.label1);
            this.Reports.Controls.Add(this.button2);
            this.Reports.Controls.Add(this.button1);
            this.Reports.Location = new System.Drawing.Point(4, 29);
            this.Reports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reports.Size = new System.Drawing.Size(1234, 653);
            this.Reports.TabIndex = 2;
            this.Reports.Text = "Reports";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_4.Location = new System.Drawing.Point(635, 537);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(68, 25);
            this.lbl_4.TabIndex = 24;
            this.lbl_4.Text = "----";
            this.lbl_4.Visible = false;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_3.Location = new System.Drawing.Point(631, 427);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(68, 25);
            this.lbl_3.TabIndex = 23;
            this.lbl_3.Text = "----";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_2.Location = new System.Drawing.Point(631, 303);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(68, 25);
            this.lbl_2.TabIndex = 22;
            this.lbl_2.Text = "----";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.lbl_1.Location = new System.Drawing.Point(631, 190);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(68, 25);
            this.lbl_1.TabIndex = 21;
            this.lbl_1.Text = "----";
            // 
            // dgv_Reports
            // 
            this.dgv_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reports.Location = new System.Drawing.Point(6, 175);
            this.dgv_Reports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Reports.Name = "dgv_Reports";
            this.dgv_Reports.RowHeadersWidth = 51;
            this.dgv_Reports.RowTemplate.Height = 24;
            this.dgv_Reports.Size = new System.Drawing.Size(619, 378);
            this.dgv_Reports.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button3.Location = new System.Drawing.Point(657, 102);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 65);
            this.button3.TabIndex = 18;
            this.button3.Text = "Customer List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GenerateCustomerList);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F);
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Generate Report";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button2.Location = new System.Drawing.Point(6, 102);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 65);
            this.button2.TabIndex = 17;
            this.button2.Text = "Consultant Schedules";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GenerateConsultantReport);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.button1.Location = new System.Drawing.Point(932, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "Monthly Appoinments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GenerateMonthlyReport);
            // 
            // MainHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1271, 841);
            this.Controls.Add(this.tab_Appointment);
            this.Controls.Add(this.btn_Exit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainHomePage";
            this.Text = "Appointment Tracker Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AppointmentGrid)).EndInit();
            this.tab_Appointment.ResumeLayout(false);
            this.Appointments.ResumeLayout(false);
            this.Appointments.PerformLayout();
            this.Customers.ResumeLayout(false);
            this.Customers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customers)).EndInit();
            this.Reports.ResumeLayout(false);
            this.Reports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_ViewWeek;
        private System.Windows.Forms.RadioButton rb_ViewMonth;
        private System.Windows.Forms.DataGridView dgv_AppointmentGrid;
        private System.Windows.Forms.Label lbl_Appointments;
        private System.Windows.Forms.Button btn_AddNewAppointment;
        private System.Windows.Forms.Button btn_ModifyAppointment;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_DeleteAppointment;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_ModifyCustomer;
        private System.Windows.Forms.TabControl tab_Appointment;
        private System.Windows.Forms.TabPage Appointments;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.DataGridView DGV_Customers;
        private System.Windows.Forms.RadioButton rb_ViewAll;
        private System.Windows.Forms.Button btn_DeleteCustomer;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_AppointmentSearch;
        private System.Windows.Forms.Button btn_ViewCustomersWithAppointments;
        private System.Windows.Forms.Button btn_AllCustomers;
        private System.Windows.Forms.DataGridView dgv_Reports;
        private System.Windows.Forms.Button btn_CustSearch;
        private System.Windows.Forms.TextBox tb_CustSearch;
        private System.Windows.Forms.Label lbl_NoMatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_4;
    }
}