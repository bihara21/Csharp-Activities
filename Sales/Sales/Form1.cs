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
using System.Xml.Linq;


namespace Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CustomerID = textBox1.Text;
            string CustomerName = textBox2.Text;
            string Date = dateTimePicker1.Text;
            string DSR = textBox4.Text;
            string Invoice = textBox5.Text;
            int Amount = int.Parse(textBox6.Text);


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string qry = "insert into SalesTable values('" + CustomerID + "','" + CustomerName + "','"+ Date +"','"+ DSR +"','"+ Invoice +"','"+ Amount +"')";

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
