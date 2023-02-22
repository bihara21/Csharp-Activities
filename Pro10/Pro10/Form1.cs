using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {


                if (textBox1.Text == "Admin" && textBox2.Text == "admin123")
                {
                    Form2 fm = new Form2();
                    fm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            else
            {
                MessageBox.Show("Enter Relevant Values");
            }


        }
    }
}
