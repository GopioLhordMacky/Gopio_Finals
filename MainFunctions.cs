using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class MainFunctions
    {
        public static void Cafe()
        {
            Console.WriteLine("\nSolve riddle to enter program: What begins with T ends with T and has T in it?");
            int a = 3;
            while (a > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer1 = "Teapot";
                string UserAnswer1 = Console.ReadLine();
                if (CorrectAnswer1 == UserAnswer1)
                {
                    CafeSystem.CafeFunc();
                    break;
                }
                else
                {
                    a--;
                    Console.WriteLine($"You have {a} attempts left.");
                }
                if (a == 0)
                {
                    Console.WriteLine("Try again later.");
                }
            }
        }

        public static void Calc()
        {
            Console.WriteLine("\nSolve riddle to enter program: What has many teeth but can’t bite?");
            int b = 3;
            while (b > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer2 = "Zipper";
                string UserAnswer2 = Console.ReadLine();
                if (CorrectAnswer2 == UserAnswer2)
                {
                    Calculator.CalcFunc();
                    break;
                }
                else
                {
                    b--;
                    Console.WriteLine($"You have {b} attempts left.");
                }
                if (b == 0)
                {
                    Console.WriteLine("Try again later.");
                }
            }
        }

        public static void Random()
        {
            Console.WriteLine("\nSolve riddle to enter program: What can you catch but not throw?");
            int c = 3;
            while (c > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer3 = "Colds";
                string UserAnswer3 = Console.ReadLine();
                if (CorrectAnswer3 == UserAnswer3)
                {
                    NumberGuess.GuessingGame();
                    break;
                }
                else
                {
                    c--;
                    Console.WriteLine($"You have {c} attempts left.");
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Try again later.");
            }
        }

        public static void Precinct()
        {
            Console.WriteLine("\nSolve riddle to enter program: What goes up but never comes down?");
            int d = 3;
            while (d > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer4 = "Age";
                string UserAnswer4 = Console.ReadLine();
                if (CorrectAnswer4 == UserAnswer4)
                {
                    VotingPrecinct.PrecinctFunc();
                    break;
                }
                else
                {
                    d--;
                    Console.WriteLine($"You have {d} attempts left.");
                }
                if (d == 0)
                {
                    Console.WriteLine("Try again later.");
                }
            }
        }

        public static void Solar()
        {
            Console.WriteLine("\nSolve riddle to enter program: Where are the lakes always empty, " +
                           "\nthe mountains always flat and the rivers always still?");
            int e = 3;
            while (e > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer5 = "Map";
                string UserAnswer5 = Console.ReadLine();
                if (CorrectAnswer5 == UserAnswer5)
                {
                    PlanetGame.SolarGame();
                    break;
                }
                else
                {
                    e--;
                    Console.WriteLine($"You have {e} attempts left.");
                }
                if (e == 0)
                {
                    Console.WriteLine("Try again later.");
                }
            }
        }
        public static void RPS()
        {
            Console.WriteLine("\nSolve riddle to enter program: I can be a blank canvas for thoughts and dreams, " +
                "\nyet fold me right and I take flight; what am I?");
            int f = 3;
            while (f > 0)
            {
                Console.Write("Enter Answer: ");
                string CorrectAnswer6 = "Paper";
                string UserAnswer6 = Console.ReadLine();
                if (CorrectAnswer6 == UserAnswer6)
                {
                    //RockPaperScissors.RockPaperScissor(username);
                    break;
                }
                else
                {
                    f--;
                    Console.WriteLine($"You have {f} attempts left.");
                }
                if (f == 0)
                {
                    Console.WriteLine("Try again later.");
                }
            }
        }
    }
}
