using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySQLClass;
using MySql.Data.MySqlClient;

namespace ZizziRestaurant
{
    public partial class frmTableSelection : Form
    {
        int numberOfDiners = 0;
        int searchDiners = 0;
        int relapseTime = 5;
        MySQLClient sqlServer = new MySQLClient("localhost", "demo", "Conrad", "Conrad2015", 3306);
        DataSet ds = new DataSet();

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
            searchDiners = numberOfDiners;

            if (searchDiners % 2 == 1)
            {
                searchDiners += 1;
            }

            lblSearch.Text = searchDiners.ToString();
        }


        public frmTableSelection(string strDiners)
        {
            InitializeComponent();
            relapseTimer.Enabled = false;

            lblnumDiners.Text = strDiners;
            numberOfDiners = Convert.ToInt32(strDiners);

            searchDiners = numberOfDiners;

            if (searchDiners % 2 == 1)
            {
                searchDiners += 1;
            }

            lblSearch.Text = searchDiners.ToString();
        }


        private void frmTableSelection_Load(object sender, EventArgs e)
        {
            sqlServer.Select("table", "Table_Status = 'Available'");

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=Conrad;password=Conrad2015";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand("select * from demo.table where Table_Status = 'Available' and Seat_Numbers = '" + searchDiners.ToString() + "'" , myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();

                myDataAdapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        frmMyMessageBox msg = new frmMyMessageBox();
        private void button1_Click(object sender, EventArgs e)
        {            
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
                msg.Hide();
                relapseTimer.Enabled = false;
            }
        }
    }
}
