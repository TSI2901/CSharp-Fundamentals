using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Factoriel(a, b);
        }
        static void Factoriel(double a, double b) 
        {
            double allA = a;
            double allB = b;
            for (double i = a-1; i > 0; i--)
            {
                allA *= i;
            }
            for (double i = b - 1; i > 0; i--)
            {
                allB *= i;
            }
            double sum = allA / allB;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
