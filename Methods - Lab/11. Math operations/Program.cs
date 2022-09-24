using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            char operation =char.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Operation(a, operation, b);
        }
        static void Operation(double A, char OP, double B) 
        {
            double sum = 0;
            if (OP == '*')
            {
                sum = A * B;
            }
            else if (OP == '+')
            {
                sum = A + B;
            }
            else if (OP == '-')
            {
                sum = A - B;
            }
            else if (OP == '/')
            {
                sum = A / B;
            }
            Console.WriteLine(sum);
        }
    }
}
