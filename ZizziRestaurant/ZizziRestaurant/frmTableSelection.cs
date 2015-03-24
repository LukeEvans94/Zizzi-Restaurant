using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZizziRestaurant
{
    public partial class frmTableSelection : Form
    {
        int numberOfDiners = 0;
        int relapseTime = 5;

        public frmTableSelection()
        {
            InitializeComponent();
        }

        public frmTableSelection(int intDiners)
        {
            InitializeComponent();
            lblnumDiners.Text = intDiners.ToString();
            numberOfDiners = intDiners;
            relapseTimer.Enabled = false;
        }

        private void frmTableSelection_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMyMessageBox msg = new frmMyMessageBox();
            msg.Show();
            relapseTimer.Enabled = true;
        }

        private void relapseTimer_Tick(object sender, EventArgs e)
        {
            relapseTime -= 1;

            if (relapseTime == 0)
            {                
                this.Hide();
                frmWelcome wel = new frmWelcome();
                wel.Show();
                relapseTimer.Enabled = false;
            }
        }
    }
}
