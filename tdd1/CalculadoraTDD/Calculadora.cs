using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTDD
{
    public class Calculadora : ICalculadora
    {
        public int Divicion(int num1, int num2)
        {
            int result = num1 / num2;
            return (result);
        }

        public int Multiplicacion(int num1, int num2)
        {
            int result = num1 * num2;
            return (result);
        }

        public int Resta(int num1, int num2)
        {
            int result = num1 - num2;
            return (result);
        }

        public int Suma(int num1, int num2)
        {
            if(num1<0 || num2<0)
                throw new ArgumentOutOfRangeException("num1 and num2 must be > 0");
            if (num1 >= int.MaxValue || num2 >= int.MaxValue)
                throw new ArgumentOutOfRangeException("num1 or num2 is too big");
            if (num1 == 666 || num2 == 666)
                throw new NumeroProhibidoException(new Exception ("numero prohibido"));

            int result = num1 + num2;
            return (result);
        }
    }
    public class NumeroProhibidoException : Exception
    {
        public NumeroProhibidoException(Exception ex)
            :base(ex.Message, ex)
        {

        }
    }
}
