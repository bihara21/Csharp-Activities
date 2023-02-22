using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Threading;
using System.Diagnostics;

namespace SalesDSR
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            String InvoiceID = textBox1.Text;
            String Payment = comboBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string upd = "update Sales1 set Payment='" + Payment + "' where InvoiceID='" + InvoiceID + "'";
            SqlCommand cmd = new SqlCommand(upd, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("update record successfully");

            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            String InvoiceID = textBox1.Text;
            String QTY = textBox2.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR001' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >=1 )
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR001'";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");
                
            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox3.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
           
            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR002' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR002' ";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");

            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox4.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
           
            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR003' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR003' ";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");

            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox5.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
           

            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR004' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR004' ";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");

            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox6.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
           

            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR005' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR005'";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");

            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox7.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            

            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR006' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "'  , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR006' ";
                SqlCommand cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");

            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            String QTY = textBox8.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter da = new SqlDataAdapter("select ProductID From Sales1 where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR007' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >=1 )
            {
                con.Open();
                string upd = "update Sales1 set QTY='" + QTY + "' , Amount=('" + QTY + "'* Price ) where InvoiceID='" + InvoiceID + "' AND ProductID= 'PR007' ";
                SqlCommand cmd = new SqlCommand(upd, con);
               
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update record successfully");
                
                
            }
            else
            {
                MessageBox.Show("This Product is not included in the Invoice");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String InvoiceID = textBox1.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
          
           

            string qry = "SELECT SUM(Amount) FROM Sales1 where InvoiceID='"+InvoiceID+"' ";
            SqlCommand com = new SqlCommand(qry, con);
           
            DataSet ds = new DataSet();

            con.Open();
            label2.Text = Convert.ToString(com.ExecuteScalar());
            con.Close();

            //Invoice Update
           
           
            string upd = "update Invoice set Total='" + label2.Text + "' where InvoiceID='" + InvoiceID + "'";
            SqlCommand cmd = new SqlCommand(upd, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("update record successfully");

            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
