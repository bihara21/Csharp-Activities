using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pro7
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num = int.Parse(textBox1.Text);
            if (Num>=18)
            {
                label2.Text = "You're Eligible to vote";
            }
            else
            {
                label2.Text = "You're not Eligible to vote";
            }
        }
    }
}
