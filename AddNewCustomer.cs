﻿using mschreiber_Software2_c969Project.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mschreiber_Software2_c969Project
{
    public partial class AddNewCustomer : Form
    {
        Customer customer = new Customer();
        bool CheckForInput = false;

        public AddNewCustomer()
        {
            //I AM HAVING ISSUES WITH THE CUSTOMER ID. I CANT AUTO INCREMENT IN THE DB SO WHAT SHOULD I DO?
            //int customerID = customer.GetCustomerID();
            InitializeComponent();
            ChangeColorofButtons();

           // lbl_custID.Text = customer.ToString();
        }

        private void ChangeColorofButtons()
        {
            //use to change the color of any button on hover
            var hoverColorChanger = new ButtonHoverColorChanger(Color.Black, Color.LimeGreen);

            hoverColorChanger.Attach(btn_Cancel);
            hoverColorChanger.Attach(btn_SaveCustomer);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel? Entries will be lost", "Caption", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                this.Hide();
            }

            else
            {
                return;
            }
        }

        private void btn_SaveAppointment_Click(object sender, EventArgs e)
        {
       
            if (txt_CustomerName.Text.Length >= 1)
            {
                CheckForInput = true;
                int customerID;
                string Name = txt_CustomerName.Text;
                string address =  txt_Address.Text;
                string city = txt_City.Text;
                string country = txt_Country.Text;
                string phoneNumber = txt_PhoneNumber.Text.ToString();

                string message = "\nPlease Verify that the following information is accurate: "
                    + "\nName: " + Name 
                    + "\nAddress: " + address 
                    + "\nCity: " + city 
                    + "\nCountry: " + country 
                    + "\nPhone Number: " + phoneNumber;

                DialogResult result = MessageBox.Show (message, "Verify Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (result == DialogResult.Yes)
                {
                    string connectionString = "server=localhost;user id=sqlUser;password=Passw0rd!;database=client_schedule";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();

                    string insertCountry = "INSERT INTO country VALUES (null, @country, NOW(), 'user', NOW(), 'user')";
                    MySqlCommand insertCountryToTable = new MySqlCommand(insertCountry, connection);

                    insertCountryToTable.Parameters.AddWithValue("@country", country);

                    insertCountryToTable.ExecuteNonQuery();

                    //Get new countryId from the country command

                    int countryID = (int)insertCountryToTable.LastInsertedId; //use this as a foreign key

                    string insertCity = "INSERT INTO city VALUES (null, @city, @countryID, NOW(), 'user', NOW(), 'user')";
                    MySqlCommand insertCityToTable = new MySqlCommand(insertCity, connection);
                    insertCountryToTable.Parameters.AddWithValue("@city", city);
                    insertCountryToTable.Parameters.AddWithValue("@countryID", countryID);

                    insertCityToTable.ExecuteNonQuery();


                    int cityID = (int)insertCityToTable.LastInsertedId;

                    //add address


                    //add customer




                   

                   

                    connection.Close();

                    MessageBox.Show("Customer saved successfully.");
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Unverified Data");
                    return;
                }
            }
        }

        private void AddNewCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
