using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto2
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

            if (1 <= N && N <= 1000)
            {
                for (int i = 1; i <= N; i++)
                {
                    string linha = textBox1.Lines[i];

                    int A = 0;
                    int B = 0;
                    int etapa = 0;
                    int j = 0;

                    while (j < linha.Length)
                    {
                        char c = linha[j];

                        if (c >= '0' && c <= '9')
                        {
                            if (etapa == 0)
                            {
                                A = A * 10 + (c - '0');
                            }
                            else
                            {
                                B = B * 10 + (c - '0');
                            }
                        }
                        else
                        {
                            if (etapa == 0)
                            {
                                etapa = 1;
                            }
                        }

                        j++;
                    }

                    int AA = A * A;
                    int diff = AA - B;
                    int total = AA + diff * diff;
                    double raiz = total / 2.0;
                    for (int k = 0; k < 10; k++)
                    {
                        raiz = (raiz + total / raiz) / 2.0;
                    }


                    int parte = (int)(raiz * 100 + 0.5);
                    double resultado = parte / 100.0;


                    textBox2.AppendText(resultado.ToString("F2") + Environment.NewLine);
                }

            }
        }
    }
}
