using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBox1.Text);
            int Num2 = int.Parse(textBox2.Text);
            if (Num1%Num2 == 0)
            {
                label3.Text = "FIRST NUMBER IS DIVISIBLE BY SECOND NUMBER";  
                
            }
            else
            {
                label3.Text = "FIRST NUMBER IS NOT DIVISIBLE BY SECOND NUMBER";
            }
        }
    }
}
