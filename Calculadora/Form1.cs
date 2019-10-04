using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private String Dado1, Dado2, Operacao, temporario, resultado;

        public Form1()
        {
            InitializeComponent();
            LimpaOperacao();
        }

        private void LimpaOperacao()
        {
            Dado1 = "";
            Dado2 = "";
            Operacao = "";
            temporario = "";
            resultado = "";
        }

        /*
         * tipo 1 = numero
         * tipo 2 = virgula
         * tipo 3 = operacao
         * tipo 4 = limpar
         * tipo 5 = calcular
         *
         */

        private void atualizarDisplay(String valor, short Tipo)
        {
            float valor1, valor2;

            switch (Tipo)
            {
                case 1:
                    temporario += valor;
                    txtDisplay.Text = txtDisplay.Text + valor;
                    break;

                case 2:
                    temporario += ".";
                    txtDisplay.Text = txtDisplay.Text + valor;
                    break;

                case 3:
                    if (Dado1 == "")
                    {
                        Dado1 = temporario;
                    }
                    temporario = "";

                    Operacao = valor;

                    txtDisplay.Text = txtDisplay.Text + valor;
                    break;

                case 4:
                    txtDisplay.Text = valor;
                    LimpaOperacao();
                    break;

                case 5:
                    if (Dado1 == "")
                    {
                        Dado1 = temporario;
                    }
                    else
                    {
                        Dado2 = temporario;
                    }

                    if (Dado1 != "" && Dado2 != "")
                    {
                        float.TryParse(Dado1, out valor1);
                        float.TryParse(Dado2, out valor2);
                        resultado = (valor + valor2).ToString();
                    }

                    txtDisplay.Text = txtDisplay.Text + valor + resultado;
                    break;

                default:
                    txtDisplay.Text = txtDisplay.Text + resultado;
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            atualizarDisplay("1", 1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            atualizarDisplay("2", 1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            atualizarDisplay("3", 1);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            atualizarDisplay("4", 1);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            atualizarDisplay("5", 1);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            atualizarDisplay("6", 1);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            atualizarDisplay("7", 1);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            atualizarDisplay("8", 1);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            atualizarDisplay("9", 1);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            atualizarDisplay("0", 1);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            atualizarDisplay("/", 3);
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            atualizarDisplay("*", 3);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            atualizarDisplay("-", 3);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            atualizarDisplay("+", 3);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            atualizarDisplay("=", 5);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            atualizarDisplay(",", 2);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            atualizarDisplay("", 4);
        }
    }
}