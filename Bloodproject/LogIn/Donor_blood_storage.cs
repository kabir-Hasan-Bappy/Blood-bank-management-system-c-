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
    public partial class Donor_blood_storage : Form

    {
        ErrorProvider ep = new ErrorProvider();

        public Donor_blood_storage()
        {
            InitializeComponent();
        }
        private void Donor_blood_storage_Load(object sender, EventArgs e)
        {
            
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select b_type from blood_bank_management.price";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                    comboBox2.Items.Add(MyReader2["b_type"]);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select donor_id,name from blood_bank_management.donor";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                    comboBox1.Items.Add(MyReader2["donor_id"]);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            ep.Clear();
            int er = 0;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Donating Blood Bag ID");

            }

            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem.ToString() == "")
            {
                er++;
                ep.SetError(comboBox1, "Enter Donor Id");

            }
            if (comboBox2.SelectedItem == null || comboBox2.SelectedItem.ToString() == "")
            {
                er++;
                ep.SetError(comboBox2, "Enter Blood Type");

            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                er++;
                ep.SetError(textBox2, "Enter Blood Bag Quantity");

            }


            if (er > 0)
                return;


            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "insert into blood_bank_management.dstorage(Dblood_id,donor_id,b_type,qty, entry_date, expire_date) values('" + this.textBox1.Text + "','" + this.comboBox1.SelectedItem.ToString() + "','" + this.comboBox2.SelectedItem.ToString()+ "','" + this.textBox2.Text + "', '"+ this.dateTimePicker1.Text+ "', '" + this.dateTimePicker2.Text + "');";

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Donor_blood_storage_Load_1(object sender, EventArgs e)
        {

            popDGV();
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select donor_id from blood_bank_management.donor";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                    comboBox1.Items.Add(MyReader2["donor_id"]);
                }
                popDGV();
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select b_type from blood_bank_management.price";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                //  MessageBox.Show("Save Data");

                while (MyReader2.Read())
                {
                   comboBox2.Items.Add(MyReader2["b_type"]);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                string Query = "delete from blood_bank_management.dstorage where Dblood_id='" + this.textBox1.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Do u want to delete this Donating Blood ID ? ", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        public void popDGV()
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

             MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            string qry = "Select * from blood_bank_management.dstorage";
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(qry, MyConn2);
            adaptar.Fill(dt);
            dataGridView_dstrg.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";


            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                   }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
