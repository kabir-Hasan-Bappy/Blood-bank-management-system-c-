using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LogIn
{
    public partial class Donor_info : Form
    {

        ErrorProvider ep = new ErrorProvider();
        public Donor_info()
        {
            InitializeComponent();
        }
        private void Donor_info_Load(object sender, EventArgs e)
        {
            
        }
            private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dbcon = "datasource=localhost; port=3306; username=root; password=;";
            string showquary = "select * from blood_bank_management.donor where donor_id='" + this.textBox6.Text + "' ; ";
            MySqlConnection myconnection = new MySqlConnection(dbcon);
            MySqlCommand dbcmd = new MySqlCommand(showquary, myconnection);
            MySqlDataReader dbreader;
            try
            {
                myconnection.Open();
                dbreader = dbcmd.ExecuteReader();
                if (dbreader.Read())
                {
                    textBox1.Text = dbreader.GetString("donor_id");
                    textBox2.Text = dbreader.GetString("name");
                    textBox3.Text = dbreader.GetString("adress");
                    textBox4.Text = dbreader.GetString("contact");
                    dateTimePicker1.Text = dbreader.GetString("entry_date");
                    dateTimePicker2.Text = dbreader.GetString("last_donate_date");
                    

                }

                else
                {
                    MessageBox.Show("No data for this DONOR ID!!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    dateTimePicker1.Text = "";
                    dateTimePicker2.Text = "";
                    
                }
                myconnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ep.Clear();
            int er = 0;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Donor ID");

            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                er++;
                ep.SetError(textBox2, "Enter Donor Name");

            }

            if (textBox3.Text == null || textBox3.Text == "")
            {
                er++;
                ep.SetError(textBox3, "Enter Donor Address");

            }

            if (textBox4.Text == null || textBox4.Text == "")
            {
                er++;
                ep.SetError(textBox4, "Enter Donor contact");

            }
            if (er > 0)
                return;

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                DateTime d1 = System.DateTime.Now.Date;
                string Query = "insert into blood_bank_management.donor(donor_id, name, adress, contact, entry_date, last_donate_date) values('" + this.textBox1.Text + "','" + this.textBox2.Text+ "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                    
                }
                popDGV();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Donor_info_Load_1(object sender, EventArgs e)
        {
            popDGV();
        }
        public void popDGV()
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            string qry = "Select * from blood_bank_management.donor";
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(qry, MyConn2);
            adaptar.Fill(dt);
            dataGridView_donor.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = "datasource=localhost; port=3306; username=root; password=;";
            string quary = "update blood_bank_management.donor set donor_id='" + this.textBox1.Text + "', name='" + this.textBox2.Text + "', adress='" + this.textBox3.Text + "', contact='" + this.textBox4.Text + "', entry_date='" + this.dateTimePicker1.Text+ "',last_donate_date='" + this.dateTimePicker2.Text + "' where donor_id='" + this.textBox1.Text + "';";
            MySqlConnection connection = new MySqlConnection(con);
            MySqlCommand command = new MySqlCommand(quary, connection);
            MySqlDataReader mydata;
            try
            {
                connection.Open();
                mydata = command.ExecuteReader();
                MessageBox.Show("Update data");
                while (mydata.Read())
                {

                }

                popDGV();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                string Query = "delete from blood_bank_management.donor where donor_id='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Do u want to delete this Donor ID ? ", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Data Deleted Successfully!!");
                }
                while (MyReader2.Read())
                {
                }

                popDGV();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

            textBox1.Focus();


         
         
        }
        
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_donor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
