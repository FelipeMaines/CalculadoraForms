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
        public string mostrarCalculo = "";
        public string opercao = "";
        public Form1()
        {
            this.calculo = new Calculo();
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " + ";
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
                if (calculo.operacao == " + ")
                {
                    int resultado = calculo.somar(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " - ")
                {
                    int resultado = calculo.subtrair(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " * ")
                {
                    int resultado = calculo.multiplicar(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " / ")
                {
                    int resultado = calculo.dividir(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
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

        //public override string ToString()
        //{
        //    return $"Primeiro numero: {calculo.primeiroNumero}, Segundo numero: {calculo.segundoNumero}, Operacao: {calculo.operacao}, Resultado: {calculo.resultado}";
        //}

        private void buttonC_Click(object sender, EventArgs e)
        {
            calculo.primeiroNumero = 0;
            calculo.segundoNumero = 0;
            strPrimeiroNumero = string.Empty;
            strSegundoNumero = string.Empty;
            calculo.mostrarCalculo = string.Empty;
            lista.Items.Clear();
            qualNumero = false;
        }

        private void buttonNumero_Click(object sender, EventArgs e)
        {
            if (!qualNumero)
            {
                if (sender is Button btn)
                {
                    strPrimeiroNumero += btn.Text;
                }
                calculo.primeiroNumero = int.Parse(strPrimeiroNumero);
                calculo.mostrarCalculo = strPrimeiroNumero;

            }
            else
            {
                if (sender is Button btn)
                {
                    strSegundoNumero += btn.Text;
                }
                calculo.segundoNumero = int.Parse(strSegundoNumero);
                mostrarCalculo += strSegundoNumero;
                calculo.mostrarCalculo = strPrimeiroNumero + calculo.operacao + strSegundoNumero;
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

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }
    }

}