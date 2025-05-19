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

namespace projeto1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Lines[0]);
            if (1 <= N && N <= 2000)
            {
                for (int i = 1; i <= N; i++)
                {
                    string valor = textBox1.Lines[i];
                    int totalLeds = 0;

                    for (int j = 0; j < valor.Length; j++)
                    {
                        char digito = valor[j];

                        if (digito == '0') totalLeds += 6;
                        else if (digito == '1') totalLeds += 2;
                        else if (digito == '2') totalLeds += 5;
                        else if (digito == '3') totalLeds += 5;
                        else if (digito == '4') totalLeds += 4;
                        else if (digito == '5') totalLeds += 5;
                        else if (digito == '6') totalLeds += 6;
                        else if (digito == '7') totalLeds += 3;
                        else if (digito == '8') totalLeds += 7;
                        else if (digito == '9') totalLeds += 6;
                    }

                    textBox2.AppendText($"{totalLeds} leds" + Environment.NewLine);
                }
            }
        }
    }
}
