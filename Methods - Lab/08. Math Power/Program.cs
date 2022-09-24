using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            CalculateTahtNumber(number, power);
        }

        static void CalculateTahtNumber(double b, double power) 
        {
            double sum = b;
            for (int i = 1; i < power; i++)
            {
                sum *= b;
            }
            Console.WriteLine(sum);
        }
    }
}
