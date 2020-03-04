using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            About ss = new About();
            ss.Show();
        }

        private void addBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddBuyer ss = new AddBuyer();
            ss.Show();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void bUYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Add_Customer ss = new Add_Customer();
            ss.Show();
        }

        private void deleteBuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buyingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BloodStorage b = new BloodStorage();
            b.Show();
            b.BringToFront();
        }

        private void addDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Donor_info ss = new Donor_info();
            ss.Show();
        }

        private void iNVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dONORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void donorBloodStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Donor_blood_storage ss = new Donor_blood_storage();
            ss.Show();
        }

        private void sellingInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selling ss = new selling();
            ss.Show();
        }

        private void freeGiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            free_give ss = new free_give();
            ss.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            label1.Text = time;
            
                
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void sELLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_page ss = new admin_page();
            ss.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                DateTime cur_date = System.DateTime.Now.Date;

                string Query = "Select blood_id, b_type, quantity, expire_date from blood_bank_management.bloodbag_info";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {

                    string bid = MyReader2["blood_id"].ToString();
                    string typ = MyReader2["b_type"].ToString();
                    int qt = Convert.ToInt32(MyReader2["quantity"].ToString());

                    string date = MyReader2["expire_date"].ToString();
                   
                    
                    DateTime exp_date = DateTime.Parse(date);

                   if((exp_date-cur_date).TotalDays <= 3 && (exp_date-cur_date).TotalDays >= 0)
                    {
                        timer2.Stop();
                        MessageBox.Show("Blood Id: " + bid + "\n" + "Blood Type: " + typ + "\n" + qt + " bag , will expire soon!");
                       
                    }
                   
                }
                MyConn2.Close();
                
            }
            catch (Exception ex)
            {
                timer2.Stop();
                MessageBox.Show(ex.Message);
                
            }
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                DateTime cur_date = System.DateTime.Now.Date;

                string Query = "Select dblood_id, b_type, qty, expire_date from blood_bank_management.dstorage";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {

                    string bid = MyReader2["dblood_id"].ToString();
                    string typ = MyReader2["b_type"].ToString();
                    int qt = Convert.ToInt32(MyReader2["qty"].ToString());

                    string date = MyReader2["expire_date"].ToString();


                    DateTime ex_date = DateTime.Parse(date);

                    if ((ex_date - cur_date).TotalDays <= 3 && (ex_date - cur_date).TotalDays >= 0)
                    {
                        timer2.Stop();
                        MessageBox.Show("Blood Id: " + bid + "\n" + "Blood Type: " + typ + "\n" + qt + " bag , will expire soon!");
                        
                    }

                }
                MyConn2.Close();

            }
            catch (Exception ex)
            {
                timer2.Stop();
                MessageBox.Show(ex.Message);

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sellingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report s = new report();
            s.Show();
        }
    }
}
