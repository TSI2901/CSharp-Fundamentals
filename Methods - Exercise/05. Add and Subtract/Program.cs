using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Subtract(a, b, c);
        }
        static void AddTwo(int a , int b) 
        {
            
            int sum = a + b;
        }
        static void Subtract(int a, int b, int c) 
        {
            
            Console.WriteLine((a + b) - c);
        }
    }
}
