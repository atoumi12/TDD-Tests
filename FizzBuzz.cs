using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class FizzBuzz
    {
        public string ConvertNumber(int input)
        {
            string response = "";
            bool estDivisibleParTois = EstDivisiblePar(input, 3);
            bool estDivisibleParCinq= EstDivisiblePar(input, 5);

            if (estDivisibleParTois)
            {
                response += "fizz";
            }

            if (estDivisibleParCinq)
            {
                response += "buzz";
            }

            bool isNormalNumber = !estDivisibleParTois && !estDivisibleParCinq;
            if (isNormalNumber)
            {
                response = input.ToString();
            }

            return response;
        }

        public bool EstDivisiblePar(int number, int divider)
        {
            if (divider == 0)
                return false;

            return (number % divider == 0);

        }
    }
}