using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int num = n;
            int j = 2;

            while (j<=num)
            {
                if (num % j == 0)
                {
                    textBox2.AppendText(num.ToString() + Environment.NewLine);
                    num /= j;
                    
                }
               
                else
                {
                    j++;
                }
                
            }
        }
    }
}
