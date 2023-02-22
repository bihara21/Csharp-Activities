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
using System.Data.SqlClient;

namespace Pro12
{
    public partial class Updateform : Form
    {
        public Updateform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Idno = int.Parse(textBox1.Text);
            String name=textBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Bihara Numanshi\OneDrive\Documents\FormDB.mdf"";Integrated Security=True;Connect Timeout=30");
            string upd = "update Signup set name='"+name+"' where ID='"+Idno+"'";
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
    }
}
