﻿using System;
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
    public partial class MainHomePage : Form
    {
        public MainHomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           //this will change the DGV based on the radio button selection
        }

        private void btn_CreateAppointment_Click(object sender, EventArgs e)
        {
            //open the createnuewappointment screen
            //perhaps add an "onmousedown" event that changes the buttoncolor
        }

        private void MainHomePageExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}