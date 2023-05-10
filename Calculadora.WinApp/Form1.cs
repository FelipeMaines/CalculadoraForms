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
        public Form1(Calculo calc)
        {
            this.calculo = calc;
            InitializeComponent();
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " + ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;
            lista.Items.Clear();

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " - ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;
            lista.Items.Clear();

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " / ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;
            lista.Items.Clear();

            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            calculo.operacao = " * ";
            calculo.mostrarCalculo += calculo.operacao;
            qualNumero = true;
            lista.Items.Clear();
            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            decimal resultado = 0;

            calculo.primeiroNumero = decimal.Parse(strPrimeiroNumero);
            calculo.segundoNumero = decimal.Parse(strSegundoNumero);

            if (!string.IsNullOrEmpty(strPrimeiroNumero) && !string.IsNullOrEmpty(strSegundoNumero))
            {
                if (calculo.operacao == " + ")
                {
                    resultado = calculo.somar(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " - ")
                {
                    resultado = calculo.subtrair(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " * ")
                {
                    resultado = calculo.multiplicar(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                else if (calculo.operacao == " / ")
                {
                    resultado = calculo.dividir(calculo.primeiroNumero, calculo.segundoNumero);
                    lista.Items.Add(resultado);
                }

                resultados.Items.Add(calculo.primeiroNumero + " " + calculo.operacao + " " + calculo.segundoNumero + " = " + resultado);

                calculo.resultado = resultado;
                this.calculo = new Calculo();
                Limpar();
            }

            else
            {
                MessageBox.Show("Faltou dados!");
                Limpar();
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
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
            AdicionarValor(sender);
        }

        private void AdicionarValor(object sender)
        {
            if (!qualNumero)
            {
                if (sender is Button btn)
                {
                    strPrimeiroNumero += btn.Text;
                }

                calculo.mostrarCalculo = strPrimeiroNumero;

            }
            else
            {
                if (sender is Button btn)
                {
                    strSegundoNumero += btn.Text;
                }

                mostrarCalculo += strSegundoNumero;
                calculo.mostrarCalculo = strPrimeiroNumero + calculo.operacao + strSegundoNumero;
            }

            lista.Items.Clear();
            lista.Items.Add(calculo.mostrarCalculo);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        private void resultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }

}