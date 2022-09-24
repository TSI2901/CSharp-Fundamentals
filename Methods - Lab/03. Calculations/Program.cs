using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (action == "add")
            {
                add(num1, num2);
            }
            else if (action == "multiply")
            {
                multiply(num1, num2);
            }
            else if (action == "subtract")
            {
                subtract(num1, num2);
            }
            else if (action == "divide")
            {
                divide(num1, num2);
            }
        }




        static void add (int Num1, int Num2)
        {
            int all = Num1 + Num2;
            Console.WriteLine(all);
        }
        static void multiply(int Num1, int Num2)
        {
            int all = Num1 * Num2;
            Console.WriteLine(all);
        }
        static void subtract(int Num1, int Num2)
        {
            int all = Num1 - Num2;
            Console.WriteLine(all);
        }
        static void divide(int Num1, int Num2)
        {
            double all = Num1 / Num2;
            Console.WriteLine(all);
        }
    }
}
