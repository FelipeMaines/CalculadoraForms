using System.Configuration;
using System.Diagnostics.Eventing.Reader;

namespace Calculadora.WinApp
{
    public partial class Form1 : Form
    {
        Calculo calculo { get; set; }
        public string strPrimeiroNumero;
        public string strSegundoNumero;
        public bool qualNumero = false;
        public string mostrarCalculo= "";
        public string opercao = "";
        public Form1()
        {
            this.calculo = new Calculo();
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            calculo.operacao =  " + ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " - ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " / ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " * ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (!validacaoNull(calculo.primeiroNumero, calculo.segundoNumero))
            {
                if (calculo.operacao == "+")
                {
                    calculo.somar(calculo.primeiroNumero, calculo.segundoNumero);
                }

                else if (calculo.operacao == "-")
                {
                    calculo.subtrair(calculo.primeiroNumero, calculo.segundoNumero);
                }

                else if (calculo.operacao == "*")
                {
                    calculo.multiplicar(calculo.primeiroNumero, calculo.segundoNumero);
                }

                else if (calculo.operacao == "/")
                {
                    calculo.dividir(calculo.primeiroNumero, calculo.segundoNumero);
                }

                
            }
            else
            {
                MessageBox.Show("Os dois itens devem ter sido preenchido");
            }
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public override string ToString()
        {
            return $"Primeiro numero: {calculo.primeiroNumero}, Segundo numero: {calculo.segundoNumero}, Operacao: {calculo.operacao}, Resultado: {calculo.resultado}";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button1.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
                
            }
            else
            {
                strSegundoNumero += button1.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                mostrarCalculo += strSegundoNumero;
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button2.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button2.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button3.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button3.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button4.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button4.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button5.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button5.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button6.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button6.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button7.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button7.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo+= strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button8.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button8.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button9.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }
            else
            {
                strSegundoNumero += button9.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += button0.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;
            }

            else
            {
                strSegundoNumero += button0.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                calculo.mostrarCalculo = strSegundoNumero;
            }

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                strPrimeiroNumero += buttonPonto.Text;
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);


            }

            else
            {
                strSegundoNumero += buttonPonto.Text;
                calculo.segundoNumero = int.Parse(strSegundoNumero);
            }
        }

        private bool validacaoNull(int n1, int n2)
        {
            if (n1 != null && n2 != null)
                return false;

            else
                return true;
        }

       
    }

}