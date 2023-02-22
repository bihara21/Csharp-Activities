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

namespace Pro12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID=int.Parse(textBox1.Text);
            String Name=textBox2.Text;
            int phno=int.Parse(textBox3.Text);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\FormDB.mdf"";Integrated Security=True;Connect Timeout=30");
            string sql = "insert into Signup values ('" + ID + "','" + Name + "','" + phno + "')";
            SqlCommand cmd=new SqlCommand(sql,con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data inserted successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
