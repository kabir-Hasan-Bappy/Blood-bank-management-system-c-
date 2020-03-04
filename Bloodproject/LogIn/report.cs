using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class report : Form
    {
        int total = 0;
        int amount = 0;
        
        
        public report()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void report_Load(object sender, EventArgs e)
        {

            try
            {

                string con = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select b_type from blood_bank_management.price";

                MySqlConnection con2 = new MySqlConnection(con);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, con2);
                MySqlDataReader MyReader2;
                con2.Open();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {
                    comboBox1.Items.Add(MyReader2["b_type"]);
                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();

                
                MySqlDataAdapter msa = new MySqlDataAdapter("Select * from blood_bank_management.invoice", MyConn2);

                DataSet ds = new DataSet();

                msa.Fill(ds);
                dataGridView_report.DataSource = ds.Tables[0];
                total = 0;
                for (int i = 0; i < dataGridView_report.Rows.Count; i++)

                {
                    amount = Convert.ToInt32(dataGridView_report.Rows[i].Cells["total_amount"].Value);

                    total = total + amount;
                }

                label4.Text = "Total Amount : " + total.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            if (comboBox1.Text != "")
            {

                string dbcon = "datasource=localhost; port=3306; username=root; password=;";


                string showquary = "select * from blood_bank_management.invoice where entry_date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND b_type = '" + comboBox1.SelectedItem.ToString() + "'";

                MySqlConnection myconnection = new MySqlConnection(dbcon);
                MySqlCommand dbcmd = new MySqlCommand(showquary, myconnection);
                MySqlDataReader dbreader;
                try
                {
                    myconnection.Open();
                    dbreader = dbcmd.ExecuteReader();
                    if (dbreader.Read())
                    {

                        try
                        {

                            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";


                            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                            MyConn2.Open();
                            MySqlDataAdapter msa = new MySqlDataAdapter("select * from blood_bank_management.invoice where entry_date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' AND b_type = '" + comboBox1.SelectedItem.ToString() + "'", MyConn2);

                            DataSet ds = new DataSet();

                            msa.Fill(ds);
                            dataGridView_report.DataSource = ds.Tables[0];
                            total = 0;
                            for (int i = 0; i < dataGridView_report.Rows.Count; i++)

                             {
                                 amount = Convert.ToInt32(dataGridView_report.Rows[i].Cells["total_amount"].Value);

                                 total = total + amount;
                             }

                             label4.Text = "Total Amount : " + total.ToString();
                             

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    else
                    {
                        MessageBox.Show("No data Found!!");

                    }
                    myconnection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                string dbcon = "datasource=localhost; port=3306; username=root; password=;";


                string showquary = "select * from blood_bank_management.invoice where entry_date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'";

                MySqlConnection myconnection = new MySqlConnection(dbcon);
                MySqlCommand dbcmd = new MySqlCommand(showquary, myconnection);
                MySqlDataReader dbreader;
                try
                {
                    myconnection.Open();
                    dbreader = dbcmd.ExecuteReader();
                    if (dbreader.Read())
                    {

                        try
                        {

                            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";


                            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                            MyConn2.Open();
                            MySqlDataAdapter msa = new MySqlDataAdapter("select * from blood_bank_management.invoice where entry_date BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'", MyConn2);

                            DataSet ds = new DataSet();

                            msa.Fill(ds);
                            dataGridView_report.DataSource = ds.Tables[0];
                            total = 0;
                             for (int i = 0; i < dataGridView_report.Rows.Count; i++)

                             {
                                 amount = Convert.ToInt32(dataGridView_report.Rows[i].Cells["total_amount"].Value);

                                 total = total + amount;
                             }

                             label4.Text = "Total Amount : " + total.ToString();
                             

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                    else
                    {
                        MessageBox.Show("No data Found!!");

                    }
                    myconnection.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private object GetString(string v)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}