using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class CafeSystem
    {
        public static void CafeFunc()
        {
            // Cafe Intro
            string[] beverage = { "" };
            int type = 0;

            //Coffee Order
            string[] coffee = { "" };
            int[] CoffeePrice = { 0 };
            int CoffeeOrder = 0;
            int CoffeeAmount = 0;
            int cost = 0;
            int total = 0;

            //Milktea Order
            string[] milktea = { "" };
            int[] MilkteaPrice = { 0 };
            int MilkteaOrder = 0;
            int MilkteaAmount = 0;
            int MilkteaCost = 0;
            int MilkteatTotal = 0;

            //Milktea Order
            string[] frappe = { "" };
            int[] FrappePrice = { 0 };
            int FrappeOrder = 0;
            int FrappeAmount = 0;
            int FrappeCost = 0;
            int FrappeTotal = 0;

            //Yogurt Order
            string[] yogurt = { "" };
            int[] YogurtPrice = { 0 };
            int YogurtOrder = 0;
            int YogurtAmount = 0;
            int YogurtCost = 0;
            int YogurtTotal = 0;

            Console.WriteLine("\nYOU HAVE SUCCESSFULLY ENTERED CAFE ORDERING SYSTEM ");
            Console.WriteLine("------------------------------------------------------");
            beverage = ["Coffee", "Milktea", "Frappe", "Yogurt"];
            Console.WriteLine(" Coffee -     0 ");
            Console.WriteLine(" Milktea -    1 ");
            Console.WriteLine(" Frappe -     2 ");
            Console.WriteLine(" Yogurt -     3 ");
            Console.Write("Input your Beverage Type: ");
            type = Convert.ToInt32(Console.ReadLine());

            switch (type)
            {
                case 0:
                    CoffeeOrders(coffee, CoffeePrice, CoffeeOrder, CoffeeAmount, cost, total);
                    break;
                case 1:
                    MilkteaOrders(milktea, MilkteaPrice, MilkteaOrder, MilkteaAmount, MilkteaCost, MilkteatTotal);
                    break;
                case 2:
                    FrappeOrders(frappe, FrappePrice, FrappeOrder, FrappeAmount, FrappeCost, FrappeTotal);
                    break;
                case 3:
                    YogurtOrders(yogurt, YogurtPrice, YogurtOrder, YogurtAmount, YogurtCost, YogurtTotal);
                    break;
                default:
                    {
                        Console.WriteLine("Invalid Input.");
                        break;
                    }
            }
        }
        
        public static void CoffeeOrders(string[] coffee, int[] CoffeePrice, int CoffeeOrder, int CoffeeAmount, int cost, int total)
        {
            coffee = ["\nBrewed Coffee", "Espresso", "Cafe Latte", "Cappuccino", "Mocha Latte", "Macchiato", "Chocolate"];
            Console.WriteLine(" Brewed Coffee -      0 ");
            Console.WriteLine(" Espresso -           1 ");
            Console.WriteLine(" Cafe Latte -         2 ");
            Console.WriteLine(" Cappuccino -         3 ");
            Console.WriteLine(" Mocha Latte -        4 ");
            Console.WriteLine(" Macchiato -           5 ");
            Console.WriteLine(" Chocolate -          6 ");
            CoffeePrice = [150, 150, 155, 160, 175, 180];
            Console.WriteLine(" ----------------------------");
            Console.Write("Enter Coffee Code: ");
            CoffeeOrder = Convert.ToInt16(Console.ReadLine());
            Console.Write("How many " + coffee[CoffeeOrder] + " would that be: ");
            CoffeeAmount = Convert.ToInt16(Console.ReadLine());
            cost = CoffeePrice[CoffeeOrder];
            total = cost * CoffeeAmount;
            Console.WriteLine($"\nYour order is {CoffeeAmount} {coffee[CoffeeOrder]}." +
                $" {coffee[CoffeeOrder]} Coffee is P{CoffeePrice[CoffeeOrder]}. Your total cost is P{total}");
        }
        public static void MilkteaOrders(string[] milktea, int[] MilkteaPrice, int MilkteaOrder, int MilkteaAmount, int MilkteaCost, int MilkteaTotal)
        {
            milktea = ["\nClassic Milktea", "Thai Milktea", "Taro Milktea", "Matcha Milktea", "Tiger Boba", "Hokaido Milktea", "Chocolate Milktea"];
            Console.WriteLine(" Classic Milktea -      0 ");
            Console.WriteLine(" Thai Milktea -         1 ");
            Console.WriteLine(" Taro Milktea -         2 ");
            Console.WriteLine(" Matcha Milktea  -      3 ");
            Console.WriteLine(" Tiger Boba -           4 ");
            Console.WriteLine(" Hokaido Milktea -      5 ");
            Console.WriteLine(" Chocolate Milktea -    6 ");
            MilkteaPrice = [120, 130, 130, 130, 145, 145, 140];
            Console.WriteLine(" ----------------------------");
            Console.Write("Enter Milktea Code: ");
            MilkteaOrder = Convert.ToInt16(Console.ReadLine());
            Console.Write("How many " + milktea[MilkteaOrder] + " would that be: ");
            MilkteaAmount = Convert.ToInt16(Console.ReadLine());
            MilkteaCost = MilkteaPrice[MilkteaOrder];
            MilkteaTotal = MilkteaCost * MilkteaAmount;
            Console.WriteLine($"\nYour order is {MilkteaAmount} {milktea[MilkteaOrder]}." +
                $"\nA {milktea[MilkteaOrder]} is P{MilkteaPrice[MilkteaOrder]}. Your total cost is P{MilkteaTotal}");
        }
        public static void FrappeOrders(string[] frappe, int[] FrappePrice, int FrappeOrder, int FrappeAmount, int FrappeCost, int FrappeTotal)
        {
            frappe = ["\nCaramel", "Strawberry", "Manggo", "Berry", "Matcha", "Hershey", "Cookies"];
            Console.WriteLine(" Caramel -      0 ");
            Console.WriteLine(" Strawberry -   1 ");
            Console.WriteLine(" Manggo -       2 ");
            Console.WriteLine(" Berry -        3 ");
            Console.WriteLine(" Matcha         4 ");
            Console.WriteLine(" Hershey -      5 ");
            Console.WriteLine(" Cookie -       6 ");
            Console.WriteLine(" Macadamia -    7 ");
            FrappePrice = [140, 145, 155, 160, 170, 175, 180];
            Console.WriteLine(" ----------------------------");
            Console.Write("Enter Frappe Code: ");
            FrappeOrder = Convert.ToInt16(Console.ReadLine());
            Console.Write("How many " + frappe[FrappeOrder] + " would that be: ");
            FrappeAmount = Convert.ToInt16(Console.ReadLine());
            FrappeCost = FrappePrice[FrappeOrder];
            FrappeTotal = FrappeCost * FrappeAmount;
            Console.WriteLine($"\nYour order is {FrappeAmount} {frappe[FrappeOrder]}." +
                $"\nA {frappe[FrappeOrder]} Frappe is P{FrappePrice[FrappeOrder]}. Your total cost is P{FrappeTotal}");
        }
        public static void YogurtOrders(string[] yogurt, int[] YogurtPrice, int YogurtOrder, int YogurtAmount, int YogurtCost, int YogurtTotal)
        {
            yogurt = ["Blueberry", "Banana", "Dark Matcha", "Strawberry", "Mixed Fruit"];
            Console.WriteLine(" Blueberry-      0 ");
            Console.WriteLine(" Banana -        1 ");
            Console.WriteLine(" Dark Matcha -   2 ");
            Console.WriteLine(" Strawberry -    3 ");
            Console.WriteLine(" Mixed Fruits  - 4 ");
            YogurtPrice = [150, 155, 165, 170, 170];
            Console.WriteLine(" ----------------------------");
            Console.Write("Enter Yogurt Code: ");
            YogurtOrder = Convert.ToInt16(Console.ReadLine());
            Console.Write("How many " + yogurt[YogurtOrder] + " would that be: ");
            YogurtAmount = Convert.ToInt16(Console.ReadLine());
            YogurtCost = YogurtPrice[YogurtOrder];
            YogurtTotal = YogurtCost * YogurtAmount;
            Console.WriteLine($"\nYour order is {YogurtAmount} {yogurt[YogurtOrder]}. " +
                $"\nA {yogurt[YogurtOrder]} Yogurt is P{YogurtPrice[YogurtOrder]}. Your total cost is P{YogurtTotal}");
        }
    }

}

