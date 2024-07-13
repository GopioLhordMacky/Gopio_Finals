using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class RockPaperScissors
    {
        public static void RockPaperScissor(string username)
        {
            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED ROCK PAPER SCISSORS ");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nFirst to get 5 points wins.");
            Console.WriteLine("Wrong spelling and capitalization is a point for the opponent.");
            string[] RPS = { "Rock", "Paper", "Scissors", "Rock", "Paper", "Scissors" };
            int a = 0;
            int b = 0;
            Console.Write($"Best of luck, {username}");
            while (a < 5 && b < 5)
            {
                
                Random random = new Random();
                int CompAnsNum;
                CompAnsNum = random.Next(0, 6);
                string CompAns = RPS[CompAnsNum];
                Console.WriteLine("\nRock, Paper, Scissors");
                Console.Write("Enter combatant:");
                string UserAns = Console.ReadLine();
                Console.WriteLine($"\n({username}) {UserAns} VS (Macky) {CompAns}");
                if ((UserAns == "Rock" && CompAns == "Scissors") ||
                     (UserAns == "Scissors" && CompAns == "Paper") ||
                     (UserAns == "Paper" && CompAns == "Rock"))
                {
                    a++;
                    Console.WriteLine("CONGRATS, YOU WIN");
                    Console.WriteLine($"{username}: {a} VS Macky: {b}");
                }
                else if (UserAns == CompAns)
                {
                    
                    Console.WriteLine($"{username}: {a} VS Macky: {b}");
                    Console.WriteLine("IT'S A TIE");
                }
                else
                {
                    b++;
                    Console.WriteLine("MACKY WINS!");
                    Console.WriteLine($"{username}: {a} VS Macky: {b}");
                }
               
            }

            if (a == 5 || b == 5 || a == b)
            {
                if (a > b)
                {
                    Console.WriteLine("\nCongrats! You beat Macky. Let's play again next time.");
                }
                else if (a < b)
                {
                    Console.WriteLine("\nI'm sorry, you lost. Better luck next time.");
                }
                else if (a == b)
                {
                    Console.WriteLine("\nIt's a tie. Nice game!");
                }
            }
        }
    }
}
