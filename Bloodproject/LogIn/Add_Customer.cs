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
    public partial class Add_Customer : Form
    {
        ErrorProvider ep = new ErrorProvider();

        public Add_Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            popDGV();
        }
        public void popDGV()
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            string qry = "Select * from blood_bank_management.customer";
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(qry, MyConn2);
            adaptar.Fill(dt);
            dataGridView_customer.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Customer ID");

            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                er++;
                ep.SetError(textBox2, "Enter Customer Name");

            }

            if (textBox3.Text == null || textBox3.Text == "")
            {
                er++;
                ep.SetError(textBox3, "Enter Customer Address");

            }

            if (textBox4.Text == null || textBox4.Text == "")
            {
                er++;
                ep.SetError(textBox4, "Enter Customer Contact");

            }
            if (er > 0)
                return;
            try
            {
                 
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                  
                string Query = "insert into blood_bank_management.customer(customer_id,name,adress,contact) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";
                 
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dbcon = "datasource=localhost; port=3306; username=root; password=;";
            string showquary = "select * from blood_bank_management.customer where customer_id='" + this.textBox5.Text + "' ; ";
            MySqlConnection myconnection = new MySqlConnection(dbcon);
            MySqlCommand dbcmd = new MySqlCommand(showquary, myconnection);
            MySqlDataReader dbreader;
            try
            {
                myconnection.Open();
                dbreader = dbcmd.ExecuteReader();
                if (dbreader.Read())
                {
                    textBox1.Text = dbreader.GetString("customer_id");
                    textBox2.Text = dbreader.GetString("name");
                    textBox3.Text = dbreader.GetString("adress");
                    textBox4.Text = dbreader.GetString("contact");


                }

                else
                {
                    MessageBox.Show("No data for this CUSTOMER ID!!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                myconnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string con = "datasource=localhost; port=3306; username=root; password=;";
            string quary = "update blood_bank_management.customer set customer_id='" + this.textBox1.Text + "', name='" + this.textBox2.Text + "', adress='" + this.textBox3.Text + "', contact='" + this.textBox4.Text + "' where customer_id='" + this.textBox1.Text + "';";
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                string Query = "delete from blood_bank_management.customer where customer_id='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                if (MessageBox.Show("Do u want to delete this Customer ID ? ", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
