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
        public int primeiroNumero;
        public int segundoNumero;
        public int resultado;
        public string operacao;
        public string mostrarCalculo;

        public Calculo()
        {
            
        }

        public int somar(int a, int b)
        {
            return a + b;
        }

        public int subtrair(int a, int b)
        {
            return a - b;
        }

        public int multiplicar(int a, int b)
        {
            return a * b;
        }

        public int dividir(int a, int b)
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
