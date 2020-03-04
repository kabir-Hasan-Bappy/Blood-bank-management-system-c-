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
    public partial class admin_page : Form
    {

        ErrorProvider ep = new ErrorProvider();

        public admin_page()
        {
            InitializeComponent();
        }

        private void admin_page_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Admin ID");

            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                er++;
                ep.SetError(textBox2, "Enter Admin Name");

            }

            if (textBox3.Text == null || textBox3.Text == "")
            {
                er++;
                ep.SetError(textBox3, "Enter Admin User Name");

            }

            if (textBox4.Text == null || textBox4.Text == "")
            {
                er++;
                ep.SetError(textBox4, "Enter Admin Password");

            }
            if (textBox5.Text == null || textBox5.Text == "Enter Admin Address")
            {
                er++;
                ep.SetError(textBox5, "");
            }
            if (textBox6.Text == null || textBox6.Text == "")
            {
                er++;
                ep.SetError(textBox6, "Enter Admin Contact");
            }

                if (er > 0)
                return;



            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "insert into blood_bank_management.admin(admin_id,name,adress,contact,username,password) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("INSERT Data");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = "datasource=localhost; port=3306; username=root; password=;";
            string quary = "update blood_bank_management.admin set admin_id='" + this.textBox1.Text + "', name='" + this.textBox2.Text + "', adress='" + this.textBox5.Text + "', contact='" + this.textBox6.Text + "', username='" + this.textBox3.Text + "', password='" + this.textBox4.Text + "' where admin_id='" + this.textBox1.Text + "';";
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
                string Query = "delete from blood_bank_management.admin where admin_id='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Do u want to delete this Admin ID ? ", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Data Deleted Successfully!!");
                }
                while (MyReader2.Read())
                {
                }
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
            textBox5.Text = "";
            textBox6.Text = "";

            textBox1.Focus();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dbcon = "datasource=localhost; port=3306; username=root; password=;";
            string showquary = "select * from blood_bank_management.admin where admin_id='" + this.textBox7.Text + "' ; ";
            MySqlConnection myconnection = new MySqlConnection(dbcon);
            MySqlCommand dbcmd = new MySqlCommand(showquary, myconnection);
            MySqlDataReader dbreader;
            try
            {
                myconnection.Open();
                dbreader = dbcmd.ExecuteReader();
                if (dbreader.Read())
                {
                    textBox1.Text = dbreader.GetString("admin_id");
                    textBox2.Text = dbreader.GetString("name");
                    textBox5.Text = dbreader.GetString("adress");
                    textBox6.Text = dbreader.GetString("contact");
                    textBox3.Text = dbreader.GetString("username");
                    textBox4.Text = dbreader.GetString("password");
                }

                else
                {
                    MessageBox.Show("No data for this Admin ID!!");
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
