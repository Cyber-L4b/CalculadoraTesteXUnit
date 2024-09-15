using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraService
    {
        public double Somar (double number1, double number2)
        {
            return number1 + number2;
        }

        public double Multiplicar(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Dividir(double number1, double number2)
        {
            if(number1 == 0)
            {
                throw new DivideByZeroException("O divisor não pode ser zero.");
            }
            return  number1 / number2;
        }

        public double Subtrair(double number1, double number2)
        {
            return number1 - number2;
        }

    }
}