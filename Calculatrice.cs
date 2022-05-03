using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Calculatrice
    {

        public int Add(string input = "")
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;


            //if(input.Contains())
            string[] delimeter = new string[] { ";/" }; 
            string[] chainesNombres = input.Split(delimeter, StringSplitOptions.None);
            int[] nombres = chainesNombres.Select(int.Parse).ToArray();


            int somme = 0;
            foreach (int nb in nombres)
            {
                somme += nb;
            }



            return somme;
        }
    }
}
