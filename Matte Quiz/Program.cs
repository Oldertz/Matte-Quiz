using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matte_Quiz
{
    class Program
    {
        static int RequestInput()                             //tar emot svar och ger felmeddelande om man skriver in en bokstav
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

            int number1 = randomGenerator.Next(11);
            int number2 = randomGenerator.Next(11);
            int answer;
            int playerAnswer; 
            int numQuestions;
            int numQuestionsLeft;
            int correctAnswer = 0;

            Console.Write("Hur många matematiska problem vill du lösa? ");
            numQuestions = Convert.ToInt32(RequestInput());
            numQuestionsLeft = numQuestions;


            while (numQuestionsLeft > 0)                     //Loopen som hanterar frågedelen av spelet. Svarar du rätt ökar det poängen.
            {

                Console.Write("Vad är " + number1 + " * " + number2 + "? ");
                answer = number1 * number2;
                playerAnswer = RequestInput();
                if (answer == playerAnswer)
                {
                    Console.WriteLine(playerAnswer + " är rätt, bra jobbat!");
                    correctAnswer++;
                }
                else
                {
                    Console.WriteLine(playerAnswer + " Är fel, försök igen..");
                }
                Console.ReadKey();
                numQuestionsLeft--;
                number1 = randomGenerator.Next(11);
                number2 = randomGenerator.Next(11);
            }

        }
    }
}



