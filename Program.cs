using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sep = new string('=', 20);
            Console.WriteLine($"\n{sep}\n Projet TDD \n{sep}\n");

            //string msg = "afgaba";
            //Console.WriteLine(msg.LastIndexOf('a'));

            DiamondKata diamondKata = new DiamondKata();
            string result = diamondKata.PrintDiamond('B');
            Console.WriteLine("\n\n"+result);


            char lettre = 'B';
            Console.WriteLine(Convert.ToChar(lettre + 1));


            Console.ReadLine();
        }
    }
}
