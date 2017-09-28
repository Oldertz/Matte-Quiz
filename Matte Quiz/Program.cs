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
            Random randomGenerator = new Random();

            int nummer1 = randomGenerator.Next(11);
            int nummer2 = randomGenerator.Next(11);
            int svar;
            int antalFrågor;
            int antalFrågorKvar;
            int antalRätt = 0;

            Console.Write("Hur många matematiska problem vill du lösa? ");
            antalFrågorKvar = RequestInput();

            Console.WriteLine(antalFrågorKvar);

        }
    }
}



