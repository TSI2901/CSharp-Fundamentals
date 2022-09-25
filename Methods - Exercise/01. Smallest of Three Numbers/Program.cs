using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Proverka(a, b, c);
        }
        static void Proverka(int a, int b, int c) 
        {
            int min = 0;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (b < a && b < c) 
            {
                min = b;
            }
            else if (c < a && c < b) 
            {
                min = c;
            }
            else
            {
                min = a;
            }
            Console.WriteLine(min);
        }
    }
}
