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
    public partial class BloodStorage : Form
    {
        ErrorProvider ep = new ErrorProvider();






        public BloodStorage()
        {
            InitializeComponent();
        }
        public void popDGV()
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";



            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            string qry = "Select * from blood_bank_management.bloodbag_info";
            DataTable dt = new DataTable();
            MySqlDataAdapter adaptar = new MySqlDataAdapter(qry, MyConn2);
            adaptar.Fill(dt);
            dataGridView_bstorage.DataSource = dt;
        }

        private void BloodStorage_Load(object sender, EventArgs e)
        {
            popDGV();

            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select seller_id from blood_bank_management.seller";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                

                while (MyReader2.Read())
                {
                    cmb_sid.Items.Add(MyReader2["seller_id"]);
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

                string Query = "Select b_type from blood_bank_management.price";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    cmb_btype.Items.Add(MyReader2["b_type"]);
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int er = 0;

            if (txt_bid.Text == null || txt_bid.Text == "")
            {
                er++;
                ep.SetError(txt_bid, "Enter Blood Bag ID");

            }

            if (cmb_btype.SelectedItem == null || cmb_btype.SelectedItem.ToString() == "")
            {
                er++;
                ep.SetError(cmb_btype, "Enter Blood Bag Type");

            }
            if (cmb_sid.SelectedItem == null || cmb_sid.SelectedItem.ToString() == "")
            {
                er++;
                ep.SetError(cmb_sid, "Enter Seller ID");

            }

            if (textBox1.Text == null || textBox1.Text == "")
            {
                er++;
                ep.SetError(textBox1, "Enter Blood Bag Quantity");

            }

            
            if (er > 0)
                return;



            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "insert into blood_bank_management.bloodbag_info(blood_id,b_type, quantity, entry_date, expire_date,seller_id) values('" + this.txt_bid.Text + "','" + this.cmb_btype.SelectedItem.ToString() + "','" + this.textBox1.Text+"', '" + this.dateTimePicker1.Text + "','" + this.dtp_expire.Value + "','" + this.cmb_sid.SelectedItem.ToString() + "');";

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

        private void cmb_sid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_btype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_bid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";
                string Query = "delete from blood_bank_management.bloodbag_info where blood_id='" + this.txt_bid.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Do u want to delete this Blood ID ? ", "Delete ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Data Deleted Successfully!!");
                } while (MyReader2.Read())
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