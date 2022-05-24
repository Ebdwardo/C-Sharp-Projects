using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class NumberGuess
    {
        static void Main(string[] args)
        {
            int numOfAttempts = 0;
            var proxy = new myInterfaceClient();
            Console.WriteLine("Enter an lower limit: ");
            int lowerLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an upper limit: ");
            int upperLimit = Convert.ToInt32(Console.ReadLine());

            int secretNum = proxy.secretNumber(lowerLimit, upperLimit);

            Console.WriteLine("Enter your Guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            numOfAttempts++;

            while(guess != secretNum)
            {
                if (guess < secretNum)
                    Console.WriteLine("Too Small!");
                else if (guess > secretNum)
                    Console.WriteLine("Too Big!");

                Console.WriteLine("Attempts: " + numOfAttempts);
                Console.WriteLine("Enter your Guess: ");
                numOfAttempts++;
                guess = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine("Attempts: " + numOfAttempts);
            Console.WriteLine("Correct!");

            Console.WriteLine("Press <Enter> to exit");
            Console.ReadLine();

        }
    }
}
