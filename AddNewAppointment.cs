﻿using System;
using mschreiber_Software2_c969Project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using mschreiber_Software2_c969Project.Model;
using System.Text.RegularExpressions;

namespace mschreiber_Software2_c969Project
{
    public partial class AddNewAppointment : Form
    {
        string connString = "Host=localhost;port=3306;Database=client_schedule;Username=sqlUser;Password=Passw0rd!";

        private int tempCustomerId;
        public AddNewAppointment()
        {
            InitializeComponent();
            ChangeColorofButtons();
            LoadCustomerComboBox();

            string[] choices = { "Lunch Meeting", "Scrum", "Synch Up" };
            cb_Choices.Items.AddRange(choices);


            string[] locations = { "Cafteria", "Boardroom A", "Lobby", "Boardroom B", "War Room" };
            cb_Location.Items.AddRange(locations);



        }

        private void LoadCustomerComboBox()
        {
            //select a customer from a dgv with customer and customerID. When you click on a row, it will auto fill the customer ID choice. 
            //that customer ID choice will be read only,

            MySqlConnection conn = new MySqlConnection(connString);

            //string query = "SELECT customer.customerId, customer.customerName, appointment.title, appointment.description, appointment.type, appointment.start, appointment.end FROM appointment INNER JOIN customer ON customer.customerId = appointment.customerID";
            string queryForCustomerOnly = "SELECT customerID from customer";

            using (MySqlCommand cmd = new MySqlCommand(queryForCustomerOnly, conn))
            {
                // Create a new MySQL data adapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cb_CustomerID.DataSource = dataTable;
                }
            }
        }

        private void SaveNewAppointment(object sender, EventArgs e)
        {

            string title = txt_Title.Text;
            string selectedChoice = cb_Choices.SelectedItem.ToString();
            string selectedLocation = cb_Location.SelectedItem.ToString();
            DateTime inputDate = DT_ScheduleAppointment.Value;
            DateTime utcDate = TimeZoneInfo.ConvertTimeToUtc(inputDate);

            DateTime endDate = TimeZoneInfo.ConvertTimeToUtc(DT_ScheduleAppointment.Value.AddMinutes(30));

            string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                //Create new Appointment          
                string insertAppointment = "INSERT INTO appointment VALUES(null, @customerID, '1', @title, description, @location, @type, 'not needed', url, @dateTime, @dateTime + 10, NOW(), 'user', NOW(), 'user')";

                //TODO for testing only, remove when functionality is complete.
                int customerID = 1;

                MySqlCommand insertAppointmentToTable = new MySqlCommand(insertAppointment, connection);
                insertAppointmentToTable.Parameters.AddWithValue("@customerID", customerID);
                insertAppointmentToTable.Parameters.AddWithValue("@title", title);
                insertAppointmentToTable.Parameters.AddWithValue("@location", selectedLocation);
                insertAppointmentToTable.Parameters.AddWithValue("@type", selectedChoice);
                //insertAppointmentToTable.Parameters.AddWithValue("@dateTime", utcDate);

                insertAppointmentToTable.ExecuteNonQuery();
            }

            catch
            {
                MessageBox.Show("Unverified Data");
                return;
            }

            finally
            {
                MainHomePage mainHomePage = new MainHomePage();
                
                mainHomePage.RefreshCustomerDataGrid();
                mainHomePage.Show();
                this.Hide();
            }
        }
        public DateTime ConvertToUtc(string inputDate)
        {
            DateTime date = DateTime.Parse(inputDate);
            DateTime utcDate = date.ToUniversalTime();
            return utcDate;
        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_SaveAppointment);
            hoverColorChanger.Attach(btn_Cancel);
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MainHomePage mainHomePage = new MainHomePage();
                this.Hide();

                mainHomePage.Show();
            }

            else
            {
                return;
            }
        }



        public void CheckForValidPhoneNumber()
        {
          

        }

        private void dgv_CustomerData_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgv_CustomerData.SelectedRows.Count > 0)
            //{
            //    string customerID = dgv_CustomerData.SelectedRows[0].Cells[0].Value.ToString();
            //    string customerName = dgv_CustomerData.SelectedRows[1].Cells[1].Value.ToString();

            //    lbl_CustomerID.Text = customerID;
            //    txt_CustomerName.Text = customerName;

            //}

        }

        private void txt_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewAppointment_Load(object sender, EventArgs e)
        {

        }

        private void cb_CustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
