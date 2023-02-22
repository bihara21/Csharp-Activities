using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SalesDSR
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           



 
        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

       


       

        private void label35_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           /* int total = int.Parse(label32.Text) + int.Parse(label31.Text) + int.Parse(label30.Text) + int.Parse(label29.Text) + int.Parse(label28.Text) + int.Parse(label27.Text) + int.Parse(label26.Text);
            label34.Text = total.ToString();*/
        }

       
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox3.Text);
            int price = int.Parse(l46.Text);
            int amount = qty * price;
            label32.Text = amount.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox4.Text);
            int price = int.Parse(l45.Text);
            int amount = qty * price;
            label31.Text = amount.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox5.Text);
            int price = int.Parse(l44.Text);
            int amount = qty * price;
            label30.Text = amount.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox6.Text);
            int price = int.Parse(l43.Text);
            int amount = qty * price;
            label29.Text = amount.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox7.Text);
            int price = int.Parse(l42.Text);
            int amount = qty * price;
            label28.Text = amount.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox8.Text);
            int price = int.Parse(l41.Text);
            int amount = qty * price;
            label27.Text = amount.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox9.Text);
            int price = int.Parse(l40.Text);
            int amount = qty * price;
            label26.Text = amount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            if (String.IsNullOrEmpty(TextBox1.Text.Trim()) || String.IsNullOrEmpty(comboBox1.Text.Trim()) || String.IsNullOrEmpty(comboBox2.Text.Trim()))
            {
                MessageBox.Show( "Required Field");
            }
            
            else
            {

                string ProductID = label12.Text;
                string ProductName = label25.Text;
                int Price = int.Parse(l46.Text);
                int QTY = int.Parse(textBox3.Text);
                int Amount = int.Parse(label32.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
                string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label13.Text;
            string ProductName = label24.Text;
            int Price = int.Parse(l45.Text);
            int QTY = int.Parse(textBox4.Text);
            int Amount = int.Parse(label31.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button5_Click_1(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label14.Text;
            string ProductName = label23.Text;
            int Price = int.Parse(l44.Text);
            int QTY = int.Parse(textBox5.Text);
            int Amount = int.Parse(label30.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label15.Text;
            string ProductName = label22.Text;
            int Price = int.Parse(l43.Text);
            int QTY = int.Parse(textBox6.Text);
            int Amount = int.Parse(label29.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label16.Text;
            string ProductName = label21.Text;
            int Price = int.Parse(l42.Text);
            int QTY = int.Parse(textBox7.Text);
            int Amount = int.Parse(label28.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label17.Text;
            string ProductName = label20.Text;
            int Price = int.Parse(l41.Text);
            int QTY = int.Parse(textBox8.Text);
            int Amount = int.Parse(label27.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string DSRName = dsr.Text;
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            string ProductID = label18.Text;
            string ProductName = label19.Text;
            int Price = int.Parse(l40.Text);
            int QTY = int.Parse(textBox9.Text);
            int Amount = int.Parse(label26.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Sales1 (Date,DSRName,Customer,InvoiceID,Payment,ProductID,ProductName,Price,QTY,Amount) values('" + Date + "','" + DSRName + "','" + Customer + "','" + Invoice + "','" + Payment + "','" + ProductID + "','" + ProductName + "','" + Price + "','" + QTY + "','" + Amount + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            
            string Date = dateTimePicker1.Text;
            string Customer = comboBox1.Text;
            string Invoice = TextBox1.Text;
            string Payment = comboBox2.Text;

            

          

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into Invoice (Date,Customer,InvoiceID,Payment) values('" + Date + "','" + Customer + "','" + Invoice + "','" + Payment + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
