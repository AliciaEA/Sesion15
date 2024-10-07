using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.models
{
    internal class Operacion
    {
        public double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;

            }
        }

        public double Potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double RaizCuadrada(double num)
        {

            try
            {
                return Math.Sqrt(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return 0;

            }
        }

        public string SalirB()
        {
            return "Adios baby, Volve Pronto";
        }

    }
}
