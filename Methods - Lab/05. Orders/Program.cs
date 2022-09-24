using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string thing = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            PrintSum(thing, n);
        }

        static void PrintSum(string drink, int NumberOfDrinks) 
        {
            double sum = 0;
            if (drink == "water")
            {
                sum = NumberOfDrinks * 1;
            }
            else if (drink == "coffee") 
            {
                sum = NumberOfDrinks * 1.50;
            }
            else if (drink == "coke")
            {
                sum = NumberOfDrinks * 1.40;
            }
            else if (drink == "snacks")
            {
                sum = NumberOfDrinks * 2;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
