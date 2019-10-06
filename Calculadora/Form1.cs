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

        private void addDado(String valor)
        {
            if (resultado != "")
            {
                Dado1 = resultado;
                Dado2 = "";
                resultado = "";
            }
            else if (Dado1 == "")
            {
                Dado1 = temporario;
            }
            else if (Dado2 == "")
            {
                Dado2 = temporario;
            }

            temporario = "";
        }

        private void atualizarDisplay(String valor, short Tipo)
        {
            double i = 1.2 + 2.3;
            switch (Tipo)
            {
                case 1:
                    temporario += valor;
                    break;

                case 2:
                    temporario += ",";
                    break;

                case 3:
                    addDado(temporario);
                    Operacao = valor;
                    break;

                case 4:
                    LimpaOperacao();
                    break;

                case 5:
                    addDado(temporario);
                    resultado = Processsar(Operacao);
                    valor += resultado;
                    break;
            }
            txtDisplay.Text = txtDisplay.Text + valor;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            atualizarDisplay("0", 1);
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

        private void btnDivide_Click(object sender, EventArgs e)
        {
            atualizarDisplay("/", 3);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            atualizarDisplay("=", 5);
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            atualizarDisplay("", 4);
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            atualizarDisplay("+", 3);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            atualizarDisplay("-", 3);
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            atualizarDisplay("*", 3);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            atualizarDisplay(",", 2);
        }

        private void LimpaOperacao()
        {
            Dado1 = "";
            Dado2 = "";
            Operacao = "";
            temporario = "";
            resultado = "";
            txtDisplay.Text = "";
        }

        private string Processsar(string operacao)
        {
            double valor1, valor2;

            if (Dado1 != "" && Dado2 != "")
            {
                double.TryParse(Dado1, out valor1);
                double.TryParse(Dado2, out valor2);

                switch (operacao)
                {
                    case "+":
                        return (valor1 + valor2).ToString();

                    case "-":
                        return (valor1 - valor2).ToString();

                    case "*":
                        return (valor1 * valor2).ToString();

                    case "/":
                        return (valor1 / valor2).ToString();

                    default:
                        return "Erro";
                }
            }

            return "Valor invalido";
        }

        /*
         * tipo 1 = numero
         * tipo 2 = virgula
         * tipo 3 = operacao
         * tipo 4 = limpar
         * tipo 5 = calcular
         *
         */
    }
}