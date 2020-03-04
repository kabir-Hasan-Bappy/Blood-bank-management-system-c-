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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {



            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Please Enter The User Name ...!";
                    textBox1.Focus();
                    return;
                }
                else
                {
                    textBox2.Focus();
                }

                if (textBox2.Text == "")
                {
                    textBox2.Text = "Please Enter The Password ...!";
                    return;
                }

                string myConnection = "datasource=localhost;port=3306;username=root;password=;";
                MySqlConnection myCon = new MySqlConnection(myConnection);
                MySqlCommand mycommand = new MySqlCommand("select * from blood_bank_management.admin where username='" + textBox1.Text + "' and password ='" + textBox2.Text + "';", myCon);
                MySqlDataReader myReader;

                myCon.Open();
                myReader = mycommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {

                    this.Hide();
                    Main_Page s = new Main_Page();
                    s.ShowDialog();


                }
                
                else
                {
                    MessageBox.Show("Incorrect username or password....plz enter Right information");
                }
                myCon.Close(); 
               

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
