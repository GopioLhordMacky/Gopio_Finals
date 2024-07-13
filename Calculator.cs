using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class Calculator
    {
        public static void CalcFunc()
        {
            //Calculator
            int num1 = 0;
            string operation = "";
            int num2 = 0;
            int sum = 0;
            int diff = 0;
            int prod = 0;
            int quo = 0;
            BasicCalculator(num1, operation, num2, sum, diff, prod, quo);
        }
        public static void BasicCalculator(int num1, string operation, int num2, int sum, int diff, int prod, int quo)
        {
            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED BASIC CALCULATOR");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter operation: ");
            operation = Console.ReadLine();
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt16(Console.ReadLine());
            switch (operation)
            {
                case "+":
                    sum = (num1 + num2);
                    Console.WriteLine("Result: " + sum);
                    break;
                case "-":
                    diff = (num1 - num2);
                    Console.WriteLine("Result: " + diff);
                    break;
                case "*":
                    prod = (num1 * num2);
                    Console.WriteLine("Result: " + prod);
                    break;
                case "/":
                    if (num1 > 0 && num2 > 0)
                    {
                        quo = (num1 / num2);
                        Console.WriteLine("Result: " + quo);
                    }
                    else if (num1 <= 0 || num2 <= 0)
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
