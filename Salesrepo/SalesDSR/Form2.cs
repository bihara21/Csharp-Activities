using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesDSR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Idno = textBox1.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\Sales.mdf"";Integrated Security=True;Connect Timeout=30");
            string del = "delete from Sales1 where InvoiceID='" +  Idno + "'";
            string del1 = "delete from Invoice where InvoiceID='" + Idno + "'";
            SqlCommand cmd = new SqlCommand(del, con);
            SqlCommand cmd1 = new SqlCommand(del1, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("record deleted successfully");

            }
            catch (SqlException es)
            {
                MessageBox.Show("" + es);
            }
        }
    }
}
