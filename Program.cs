using Final_Project_with_Class;
using System;
namespace WithClass
{
    internal class Finals
    {
        static void Main(string[] args)
        {
            string username = "";
            string userinput1 = "";
            string userinput = "";
            string password = "";
            int ProgEnd = 0;
            while (ProgEnd == 0)
            {
                Console.Clear();
                Console.WriteLine("\nPREMIUM [1] -- LIMITED [2] -- EXIT [3]");
                Console.Write("Enter choice: ");
                int response = Convert.ToInt16(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nSign Up [1] -- Login [2]: ");
                        Console.Write("Enter choice: ");
                        int PasswordChoice = Convert.ToInt32(Console.ReadLine());
                        switch (PasswordChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("\nCreate your username: ");
                                username = Console.ReadLine();
                                Console.WriteLine("You have successfully created your username!\n");

                                Console.WriteLine("Login");
                                Console.Write("Enter username: ");
                                userinput1 = Console.ReadLine();
                                Console.Write("Input Password: ");
                                userinput = Console.ReadLine();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("\nEnter your username: ");
                                userinput1 = Console.ReadLine();
                                Console.Write("Input Password: ");
                                userinput = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid Input");
                                break;
                        }
                        if (Membership.PremiumLogin( password, username, userinput, userinput1) == 3)
                        {
                            Console.WriteLine($"\nWELCOME USER, YOUR EXTRAORDINARY EXPERIENCE BEGINS HERE!");
                            int PremiumLoop = 1;
                            while (PremiumLoop > 0)
                            {
                                Console.WriteLine("\nThis is a multifunction program. Choose a function below: ");
                                Console.WriteLine("1    Cafe Order");
                                Console.WriteLine("2    Basic Calculator");
                                Console.WriteLine("3    Number Guessing Game");
                                Console.WriteLine("4    Voter's Precinct");
                                Console.WriteLine("5    Solar System Game");
                                Console.WriteLine("6    Rock Paper Scissors");
                                Console.WriteLine("7    Exit");
                                Console.Write("Enter Function Number: ");
                                int UserChoice = Convert.ToInt32(Console.ReadLine());

                                switch (UserChoice)
                                {
                                    case 1:
                                        CafeSystem.CafeFunc();
                                        break;
                                    case 2:
                                        Calculator.CalcFunc();
                                        break;
                                    case 3:
                                        NumberGuess.GuessingGame();
                                        break;
                                    case 4:
                                        VotingPrecinct.PrecinctFunc();
                                        break;
                                    case 5:
                                        PlanetGame.SolarGame();
                                        break;
                                    case 6:
                                        RockPaperScissors.RockPaperScissor(username);
                                        break;
                                    case 7:
                                        Console.WriteLine($"Thank you for using the program, {username}");
                                        PremiumLoop--;
                                        break;
                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                        }
                        else
                        {

                            Console.WriteLine("\nIncorrect Credentials. ");
                            break;
                        }
                        break;
 
                    case 2:
                    Console.Write("\nEnter 'Limited' Password: ");
                    userinput = Console.ReadLine();
                    if (Membership.FreeLogin(userinput) == 2)
                    {
                            Console.WriteLine("\nWELCOME TO THE LIMITED VERSION");
                        int FreeLoop = 1;
                        while (FreeLoop > 0)
                        {
                            Console.WriteLine("\nThis is a multifunction program. Choose a function below: ");
                            Console.WriteLine("1    Cafe Order");
                            Console.WriteLine("2    Basic Calculator");
                            Console.WriteLine("3    Exit");
                            Console.Write("Enter Function Number: ");
                            int UserChoice = Convert.ToInt16(Console.ReadLine());
                            switch (UserChoice)
                            {
                                case 1:
                                        CafeSystem.CafeFunc();
                                        break;
                                case 2:
                                        Calculator.CalcFunc();
                                        break;
                                case 3:
                                    Console.WriteLine("Thank you for using the program!");
                                    FreeLoop--;
                                    break;
                                default:
                                    Console.WriteLine("Invalid Input");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect Credentials. ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
                case 3:
                    Console.WriteLine("Thank you for using the program!");
                    ProgEnd++;
                    break;

                }


            }
        }
    }
}
    