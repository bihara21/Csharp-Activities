using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro4
{
    public partial class Form1 : Form
    {
        int num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            num1 = rnd.Next(1, 100);
            label1.Text=num1.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            num2 = rnd.Next(1, 100);
            label2.Text = num2.ToString();
            if (num1 > num2)
                label3.Text = "Player 1 is winner";
            else
                label3.Text = "Player 2 is winner";
        }
    }
}
