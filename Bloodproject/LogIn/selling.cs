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
    public partial class selling : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; Initial Catalog='blood_bank_management'; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;
        ErrorProvider ep = new ErrorProvider();
        string type = "";
        public selling()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void selling_Load(object sender, EventArgs e)
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
               

                while (MyReader2.Read())
                {
                    comboBox1.Items.Add(MyReader2["b_type"]);
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


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();

             
                MySqlDataAdapter msa = new MySqlDataAdapter("Select blood_id, b_type, quantity, expire_date from blood_bank_management.bloodbag_info", MyConn2);

                DataSet ds = new DataSet();

                msa.Fill(ds);
                dataGridView_sell.DataSource = ds.Tables[0];



               

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

                //MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter msa = new MySqlDataAdapter("Select customer_id, name from blood_bank_management.customer", MyConn2);

                DataSet ds = new DataSet();
                msa.Fill(ds);
                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "customer_id";
                comboBox2.SelectedValue = 0;
                MyConn2.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                type = comboBox1.SelectedItem.ToString();
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();

                //MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter msa = new MySqlDataAdapter("Select blood_id, b_type, quantity, expire_date from blood_bank_management.bloodbag_info where b_type='" + type + "'", MyConn2);

                DataSet ds = new DataSet();

                msa.Fill(ds);
                dataGridView_sell.DataSource = ds.Tables[0];



                //  MessageBox.Show("Save Data");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ep.Clear();
            int er = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("blood_id", typeof(string));
            dt.Columns.Add("b_type", typeof(string));
            dt.Columns.Add("quantity", typeof(int));

            foreach (DataGridViewRow row in dataGridView_sell.SelectedRows)
            {
                dt.Rows.Add(row.Cells["blood_id"].Value, row.Cells["b_type"].Value, row.Cells["quantity"].Value);

            }

            string name = comboBox2.Text;
            if (comboBox2.SelectedValue == null || comboBox2.SelectedValue.ToString() == "")
            {
                er++;
                ep.SetError(comboBox2, "Please select the Customer Name");
            }

            if (er > 0)
                return;
            this.Hide();
            invoice ss = new invoice(dt, name);
            ss.Show();





        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


