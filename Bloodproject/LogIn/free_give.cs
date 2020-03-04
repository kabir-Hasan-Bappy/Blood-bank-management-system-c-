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
    public partial class free_give : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; Initial Catalog='blood_bank_management'; username=root; password=;");
        ErrorProvider ep = new ErrorProvider();
        string type = "";
        string db = "";
        string ex = "";
        DataTable dt = new DataTable();
        string ddb = "";

        


        public free_give()
        {
            InitializeComponent();
        }
        public void popDGV ()
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";


                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();

                //MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter msa = new MySqlDataAdapter("Select Dblood_id, b_type, qty, expire_date from blood_bank_management.dstorage", MyConn2);

                DataSet ds = new DataSet();

                msa.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



                //  MessageBox.Show("Save Data");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void free_give_Load(object sender, EventArgs e)
        {
            popDGV();
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
                    comboBox1.Items.Add(MyReader2["b_type"]);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MySqlDataAdapter msa = new MySqlDataAdapter("Select Dblood_id, b_type, qty, expire_date from blood_bank_management.dstorage where b_type='" + type + "'", MyConn2);

                DataSet ds = new DataSet();

                msa.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



                //  MessageBox.Show("Save Data");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ep.Clear();
            int er = 0;

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Free give ID");

            }
            if (textBox2.Text == null || textBox2.Text == "")
            {
                er++;
                ep.SetError(textBox2, "Enter Name");

            }
            if (textBox3.Text == null || textBox3.Text == "")
            {
                er++;
                ep.SetError(textBox3, "Contact");

            }
            if (er > 0)
                return;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                db = dataGridView1.Rows[item.Index].Cells[0].Value.ToString();
                type = dataGridView1.Rows[item.Index].Cells[1].Value.ToString();
                int qty = Convert.ToInt32(dataGridView1.Rows[item.Index].Cells[2].Value);
                ex = dataGridView1.Rows[item.Index].Cells[3].Value.ToString();



                try
                {

                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                    string Query = "insert into blood_bank_management.free_give (fg_id, name, contact, entry_date, Dblood_id, b_type, qty, expire_date ) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + System.DateTime.Now.ToLongDateString() + "','" + db + "', '" + type + "', '" + qty + "','" + ex + "')";
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

                try
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                    string Query = "delete from blood_bank_management.dstorage where Dblood_id='" + db + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();

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

        private void button2_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
