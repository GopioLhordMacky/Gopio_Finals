using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class PlanetGame
    {
        public static void SolarGame()
        {
            //Solar Game
            int QuestionChoice = 0;
            int QuestionNumber = 0;
            int TotalPoints = 0;
            int a = 0;
            string Saturn = "";
            int b = 0;
            string Mars = "";
            int c = 0;
            string Venus = "";
            int d = 0;
            string Uranus = "";
            int e = 0;
            string Jupiter = "";
            int f = 0;
            string Earth = "";
            int g = 0;
            string Mercury = "";
            int h = 0;
            string Neptune = "";
            SolarTrivia(QuestionChoice, QuestionNumber, TotalPoints, a, Saturn, b, Mars, c, Venus, d, Uranus, e, Jupiter, f, Earth, g, Mercury, h, Neptune);
        }
        public static void SolarTrivia(int QuestionChoice, int QuestionNumber, int TotalPoints, int a, string Saturn, int b, string Mars, int c,
           string Venus, int d, string Uranus, int e, string Jupiter, int f, string Earth, int g, string Mercury, int h, string Neptune)
        {
            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED THE SOLAR QUIZ ");
            Console.WriteLine("------------------------------------------------");
            Random random = new Random();
            HashSet<int> number = new HashSet<int>();
            QuestionChoice = 0;
            QuestionNumber = 0;
            QuestionChoice = 0;
            TotalPoints = 0;
            while (number.Count < 9)
            {
                QuestionChoice = random.Next(1, 10);
                if (number.Add(QuestionChoice))
                {
                    switch (QuestionChoice)
                    {
                        case 1:
                            a = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet has 3 separate rings systems around it?");
                            while (a > 0)
                            {
                                Console.Write("Answer: ");
                                Saturn = Console.ReadLine();
                                if (Saturn == "Saturn")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine("The rings of Saturn are one of its most distinctive" +
                                        "\nfeatures and can be seen from Earth with a telescope.");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    a--;
                                    Console.WriteLine($"You have {a} attempts left.");
                                }
                            }
                            if (a == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 2:
                            b = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet is called the Red Planet?");
                            while (b > 0)
                            {
                                Console.Write("Answer: ");
                                Mars = Console.ReadLine();
                                if (Mars == "Mars")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine("This distinct coloration is caused by the presence of" +
                                        "\niron minerals in the Martian soil," +
                                        " \nwhich give the planet its characteristic red appearance.");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    b--;
                                    Console.WriteLine($"You have {b} attempts left.");
                                }
                            }
                            if (b == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;
                        case 3:
                            c = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet is named after the Roman goddess of love and beauty?");
                            while (c > 0)
                            {
                                Console.Write("Answer: ");
                                Venus = Console.ReadLine();
                                if (Venus == "Venus")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine("The name Venus was given to this planet because of its brightness and beauty," +
                                        " \nresembling the qualities associated with the goddess Venus.");
                                    TotalPoints++;
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
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 4:
                            d = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet has 22 moons?");
                            while (d > 0)
                            {
                                Console.Write("Answer: ");
                                Uranus = Console.ReadLine();
                                if (Uranus == "Uranus")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine("These moons vary in size and composition, " +
                                        "\nwith some being large and others being small. ");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    d--;
                                    Console.WriteLine($"You have {d} attempts left.");
                                }
                            }
                            if (d == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 5:
                            e = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet is the largest planet in the the Solar System?");
                            while (e > 0)
                            {
                                Console.Write("Answer: ");
                                Jupiter = Console.ReadLine();
                                if (Jupiter == "Jupiter")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine(" It has a diameter of about 143,000 kilometers," +
                                        "\nwhich is more than 11 times the diameter of Earth." +
                                        "\nIts large size is due to its high mass, " +
                                        "\nwhich allows it to have a strong gravitational pull.  ");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    e--;
                                    Console.WriteLine($"You have {e} attempts left.");
                                }
                            }
                            if (e == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 6:
                            f = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which is the only planet known to harbor life?");
                            while (f > 0)
                            {
                                Console.Write("Answer: ");
                                Earth = Console.ReadLine();
                                if (Earth == "Earth")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine("It has a suitable distance from the sun, which allows for liquid water" +
                                        "\nto exist on its surface. Earth also has a stable climate," +
                                        "\nan atmosphere that protects and supports life, and a diverse range of ecosystems. ");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    f--;
                                    Console.WriteLine($"You have {f} attempts left.");
                                }
                            }
                            if (f == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 7:
                            g = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet is closest to the Sun?");
                            while (g > 0)
                            {
                                Console.Write("Answer: ");
                                Mercury = Console.ReadLine();
                                if (Mercury == "Mercury")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine(" It is located closest to the Sun in our solar system," +
                                        "\nwith an average distance of about 36 million miles. ");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    g--;
                                    Console.WriteLine($"You have {g} attempts left.");
                                }
                            }
                            if (g == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        case 8:
                            h = 3;
                            QuestionNumber++;
                            Console.WriteLine($"\n{QuestionNumber}.) Which planet is farthest from the Sun?");
                            while (h > 0)
                            {
                                Console.Write("Answer: ");
                                Neptune = Console.ReadLine();
                                if (Neptune == "Neptune")

                                {
                                    Console.WriteLine("CORRECT!");
                                    Console.WriteLine(" It is located closest to the Sun in our solar system," +
                                        "\nwith an average distance of about 36 million miles. ");
                                    TotalPoints++;
                                    break;
                                }
                                else
                                {
                                    h--;
                                    Console.WriteLine($"You have {h} attempts left.");
                                }
                            }
                            if (h == 0)
                            {
                                Console.WriteLine($"Sorry. You weren't able to answer Question {QuestionNumber}.");
                            }
                            break;

                        default:
                            Console.WriteLine("DONE");
                            break;
                    }
                }
            }
            if (number.Count == 9)
            {
                Console.WriteLine($"\nYou got {TotalPoints} out of 8 points.");
                Console.WriteLine("Thank you for playing. An investment in knowledge pays the best interest.");
            }
        }
    }
}
