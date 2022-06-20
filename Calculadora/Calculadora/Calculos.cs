using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Calculos
    {

        private double resultado;


        public double Resultado { get { return resultado; } }



        public Calculos() {
            this.resultado = 0;
           
        }

        public double Soma(double valor)
        {
            return resultado = resultado + valor;
        }


        public double Subtrair(double valor)
        {
            return resultado = resultado - valor;
        }


        public double Dividir(double valor)
        {
            return resultado = resultado / valor;
        }


       public double Multiplicar(double valor)
        {
            return resultado = resultado * valor;
        }

        public void Zerar()
        {
            this.resultado = 0;
        }



    }
}
