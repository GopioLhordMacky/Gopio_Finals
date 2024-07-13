using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class NumberGuess
    {
        public static void GuessingGame()
        {
            //Guessing Game
            int randoms = 0;
            int guesses = 0;
            int ans = 0;
            GuessGame(randoms, guesses, ans);
        }
        public static void GuessGame(int randoms, int guesses, int ans)
        {
            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED GUESSING RANDOM NUMBER GAME ");
            Console.WriteLine("----------------------------------------------------------");
            Random random = new Random();
            randoms = random.Next(1, 101);
            guesses = 0;
            while (guesses != randoms)
            {
                Console.Write("Guess the Random Number (1-100): ");
                ans = Convert.ToInt16(Console.ReadLine());
                if (ans > randoms)
                {
                    Console.WriteLine("Lower");
                    guesses++;
                }
                else if (ans < randoms)
                {
                    Console.WriteLine("Higher");
                }
                else if (ans == randoms)
                {
                    Console.WriteLine("Perfect. Congratulations!");
                    Console.WriteLine($"You had a total of {guesses} guesses. Nice!");
                    break;
                }
            }
        }
    }
}
