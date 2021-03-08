using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static int totalGuesses = 0;
        static int randomNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the guessing game!");

            bool playAgain;
            do //Game loop
            {
                SetupGame();
                GuessingLoop();
                Console.WriteLine("Would you like to play again? (y/n)");
                string playAgainInputString = Console.ReadLine();
                playAgain = playAgainInputString.Equals("y", StringComparison.CurrentCultureIgnoreCase);

            } while (playAgain);
        }

        static void SetupGame()
        {
            totalGuesses = 0;
            Console.WriteLine("Select difficulty: (1) easy, (2) medium, (3) hard");
            string response = Console.ReadLine();
            int difficulty = int.Parse(response);
            int maxNumber;
            switch (difficulty)
            {
                default:
                case 1:
                    Console.WriteLine("You selected easy");
                    maxNumber = 10;
                    break;
                case 2:
                    Console.WriteLine("You selected medium");
                    maxNumber = 100;
                    break;
                case 3:
                    Console.WriteLine("You selected hard");
                    maxNumber = 1000;
                    break;
            }

            GetRandomNumberForGame(maxNumber);
            Console.WriteLine("Please guess a number between 1 and " + maxNumber + " inclusive.");
        }

        private static int GetGuessFromUser()
        {
            totalGuesses++;
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }

        private static void GetRandomNumberForGame(int maxNumber)
        {
            Random random = new Random();
            //generate a number between 1 and 10 inclusive.
            //+1 because upperbound in random.Next is exclusive
            randomNumber = random.Next(1, maxNumber + 1);
        }

        static void GuessingLoop()
        {
            int userGuess;
            do //guessing loop
            {
                userGuess = GetGuessFromUser();

                if (userGuess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high. Try again.");
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations you guessed correctly!");
                    Console.WriteLine("It took " + totalGuesses + " guesses.");
                }

            } while (userGuess != randomNumber);
        }
    }
}
