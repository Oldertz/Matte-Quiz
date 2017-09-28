using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matte_Quiz
{
    class Program
    {
        static int RequestInput() //tar emot svar och ger felmeddelande om man skriver in en bokstav
        {
            int playerAnswer;
            while (!int.TryParse(Console.ReadLine(), out playerAnswer))
            {
                Console.WriteLine("*ERROR* Kan ej läsa, använd siffror.");
            }

            return playerAnswer;
        }

        static void Main(string[] args)
        {
            Random randomgen = new Random();

      

            Console.Write("Hur många matematiska problem vill du lösa? ");
            RequestInput();

        }
    }
}



