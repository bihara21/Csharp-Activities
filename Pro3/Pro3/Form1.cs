using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Pro3
{
   
    public partial class Form1 : Form
    {
        int Num = 0;//Global variable Declaration
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Num++;
            lbl1.Text = Num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
