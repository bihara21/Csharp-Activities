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

namespace Pro11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID =int.Parse(txtID.Text);
            string Name=txtName.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\TestDB.mdf;Integrated Security=True;Connect Timeout=30");
            string qry = "insert into UserInfo values('"+ID+"','"+Name+"')";
            SqlCommand cmd=new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
