using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            CalculateArea(a, b);
        }

        static void CalculateArea(int A, int B) 
        {
            int sum = A * B;
            Console.WriteLine(sum);
        }
    }
}
