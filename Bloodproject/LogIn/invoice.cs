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
    public partial class invoice : Form
    {
        private int visitCounter = 0;
        DataTable newdt = new DataTable();
        ErrorProvider ep = new ErrorProvider();
        string customername = "";
        string customerid = "";
        string bt = "";
        int price = 0;
        int qty = 0;
        int total_amount = 0;
        int sub_total = 0;
        string bid = "";
        public void priceinfo(string btype)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select price from blood_bank_management.price where b_type= '"+ btype+ "' ";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    price = Convert.ToInt32(MyReader2["price"].ToString());
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }
        public void customerinfo(string name)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select customer_id from blood_bank_management.customer where name= '" + name + "' ";

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    customerid = MyReader2["customer_id"].ToString();
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        public invoice(DataTable dt, string name)
        {
            newdt = dt;
            customername = name;
            InitializeComponent();
        }

        private void invoice_Load(object sender, EventArgs e)
        {
            int temp = 0;
            int max = 0;
            try
            {

                string con = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "Select invoice_no from blood_bank_management.invoice";

                MySqlConnection con2 = new MySqlConnection(con);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, con2);
                MySqlDataReader MyReader2;
                con2.Open();
                MyReader2 = MyCommand2.ExecuteReader();


                while (MyReader2.Read())
                {
                    temp = Convert.ToInt32(MyReader2["invoice_no"]);
                    max = Math.Max(max, temp);
                }
                con2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            // Increase each time a form is loaded
            visitCounter = max+1;

            label15.Text = visitCounter.ToString("00000");



           button1.Visible = true;
           button2.Visible = true;
            

            label16.Text = customername;
            
            dataGridView_invoice.DataSource = newdt;   // dt=newdt=dgv_invoice


            for (int i = 0; i < dataGridView_invoice.Rows.Count; i++)
            {
                bt = (dataGridView_invoice.Rows[i].Cells["b_type"].Value).ToString();
                bid = (dataGridView_invoice.Rows[i].Cells["blood_id"].Value).ToString();
                priceinfo(bt);
                qty = Convert.ToInt32(dataGridView_invoice.Rows[i].Cells["quantity"].Value);
                sub_total = (qty * price);
                dataGridView_invoice.Rows[i].Cells["subtotal"].Value = sub_total;
                total_amount = total_amount + sub_total;
            }
            label4.Text = "Total Amount : " + total_amount.ToString();
            customerinfo(customername);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;";

                string Query = "insert into blood_bank_management.invoice (invoice_no,entry_date, customer_id, b_type, quantity, total_amount ) values ('" + label15.Text + "','" + dateTimePicker1.Text + "','" + customerid + "', '" + bt + "', '" + qty + "','" + total_amount + "')";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("SOLD !!");
                while (MyReader2.Read())
                {
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
                string Query = "delete from blood_bank_management.bloodbag_info where blood_id='" + bid + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
               
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

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
            button1.Visible = true;
            button2.Visible = true;
            
        }
        Bitmap bmp;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }

    internal class NorthWindEntities
    {
        public NorthWindEntities()
        {
        }
    }
}
