﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZizziRestaurant//Test
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

       

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDiners.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiners.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtDiners.Text = txtDiners.Text.Remove(txtDiners.Text.Length - 1, 1);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtDiners.Text != "" && !txtDiners.Text.StartsWith("0"))
            {
                frmTableSelection tb = new frmTableSelection();
                tb.Show();
                this.Hide();
            }
                
        }



       

       
        
    }
}
