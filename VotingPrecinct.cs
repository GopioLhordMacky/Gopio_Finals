using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class VotingPrecinct
    {
        public static void PrecinctFunc()
        {
            //Voting System
            int age = 0;
            int referenceNumber = 0;
            string precinct = "";
            VotingSystem(age, referenceNumber, precinct);
        }
        public static void VotingSystem(int age, int referenceNumber, string precinct)
        {
            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED THE BINAN LAGUNA VOTING SYSTEM ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("Enter your age: ");
            age = Convert.ToInt16(Console.ReadLine());
            if (age >= 0 && age <= 100)
            {
                if (age >= 60 && age <= 100)
                {
                    Console.WriteLine("You can vote and be in exclusive Senior Citizen Precinct.\nRepublic Act 10366");

                    Console.Write("Enter your 6-digit unique Reference Number:");
                    referenceNumber = Convert.ToInt32(Console.ReadLine());

                    precinct = "";

                    if (referenceNumber >= 100000 && referenceNumber <= 199999)
                    {
                        precinct = "BIÑAN ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 200000 && referenceNumber <= 299999)
                    {
                        precinct = "TURALBA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 300000 && referenceNumber <= 399999)
                    {
                        precinct = "GANADO ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 400000 && referenceNumber <= 499999)
                    {
                        precinct = "SAN VICENTE ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 500000 && referenceNumber <= 599999)
                    {
                        precinct = "LANGKIWA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 600000 && referenceNumber <= 699999)
                    {
                        precinct = "ADELINA CLUBHOUSE";
                    }
                    else if (referenceNumber >= 700000 && referenceNumber <= 799999)
                    {
                        precinct = "SANTO TOMAS HIGH SCHOOL";
                    }
                    else if (referenceNumber >= 800000 && referenceNumber <= 899999)
                    {
                        precinct = "LOMA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 900000 && referenceNumber <= 999999)
                    {
                        precinct = "MALABAN ELEMENTARY SCHOOL";
                    }
                    else
                    {
                        precinct = "Unknown Precinct.";
                    }
                    Console.WriteLine($"Your designated voting precinct is: {precinct}.\n" +
                        $"An election officer will guide you to your established precinct.");
                }
                else if (age >= 18 && age < 60)
                {
                    Console.WriteLine("You can vote.");

                    Console.Write("Enter your 6-digit unique Reference Number:");
                    referenceNumber = Convert.ToInt32(Console.ReadLine());

                    precinct = "";

                    if (referenceNumber >= 100000 && referenceNumber <= 199999)
                    {
                        precinct = "BIÑAN ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 200000 && referenceNumber <= 299999)
                    {
                        precinct = "TURALBA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 300000 && referenceNumber <= 399999)
                    {
                        precinct = "GANADO ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 400000 && referenceNumber <= 499999)
                    {
                        precinct = "SAN VICENTE ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 500000 && referenceNumber <= 599999)
                    {
                        precinct = "LANGKIWA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 600000 && referenceNumber <= 699999)
                    {
                        precinct = "ADELINA CLUBHOUSE";
                    }
                    else if (referenceNumber >= 700000 && referenceNumber <= 799999)
                    {
                        precinct = "SANTO TOMAS HIGH SCHOOL";
                    }
                    else if (referenceNumber >= 800000 && referenceNumber <= 899999)
                    {
                        precinct = "LOMA ELEMENTARY SCHOOL";
                    }
                    else if (referenceNumber >= 900000 && referenceNumber <= 999999)
                    {
                        precinct = "MALABAN ELEMENTARY SCHOOL";
                    }
                    else
                    {
                        precinct = "Unknown Precinct.";
                    }

                    Console.WriteLine($"Your designated voting precinct is: {precinct}");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You are not eligible to vote.");
                }
            }
        }
    }
}
