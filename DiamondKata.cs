using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class DiamondKata
    {
        public string PrintDiamond(char pLetter)
        {
            string diamond = "";

            if (pLetter == 'A')
                return pLetter.ToString();

           

            int spaceBetweenLetter = 1;
            int indexOfLetter = GetAlpha().LastIndexOf(pLetter);
            int spaceBeforeLetter = indexOfLetter;

            string ligneDeLetteA = $"{new string(' ', indexOfLetter)}A";
            diamond += $"{ligneDeLetteA}\n";

            // partie supérieure
            while (spaceBetweenLetter <= indexOfLetter)
            {
                for (int i = 1; i <= indexOfLetter; i++)
                {
                    spaceBeforeLetter--;
                    diamond += $"{new string(' ', spaceBeforeLetter)}{GetAlpha()[i]}{new string(' ', spaceBetweenLetter)}{GetAlpha()[i]}\n";
                    spaceBetweenLetter+= 2;
                }
            }


            // partie inferieure
            string[] lettres = diamond.Split('\n');
            for (int i = lettres.Length-3; i > 0; i--)
            {
                diamond += $"{lettres[i]}\n";
            }

            diamond += ligneDeLetteA;


            return diamond;
        }

        
        private string GetAlpha()
        {
            return "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        }
    }
}