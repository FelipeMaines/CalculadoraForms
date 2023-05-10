using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.WinApp
{
    public class Calculo
    {
        public decimal primeiroNumero;
        public decimal segundoNumero;
        public decimal resultado;
        public string operacao;
        public string mostrarCalculo;
        public List<Calculo> listaDeCalculos = new List<Calculo>();

        public Calculo()
        {
            
        }

        public decimal somar(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal dividir(decimal a, decimal b)
        {
            if(b != 0)
                return a / b;

            else
            {
                MessageBox.Show("Segundo numero nao pode ser 0!");
                return 0;
            }
        }
    }
}
