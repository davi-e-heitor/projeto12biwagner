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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int numf = n;
            string r = "";
            textBox2.Clear();

            while (n > 1)
            {
                r += n.ToString() + "\n";

                int divisor = 2;
                while (divisor <= n)
                {
                    if (n % divisor == 0)
                    {
                        n = n / divisor;
                        break;
                    }
                    else
                    {
                        divisor++;
                    }
                }
            }


            string linha = "";
            for (int i = r.Length - 1; i >= 0; i--)
            {
                char c = r[i];

                if (c == '\n')
                {
                    for (int j = linha.Length - 1; j >= 0; j--)
                    {
                        textBox2.AppendText(linha[j].ToString());
                    }
                    textBox2.AppendText(Environment.NewLine);
                    linha = "";
                }
                else
                {
                    linha += c;
                }

            }
            textBox2.AppendText(numf.ToString());
        }
    }
}
