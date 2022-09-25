using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Proverka(input);
        }
        static void Proverka(string input) 
        {
            int lenght = input.Length;
            if (lenght % 2 == 0)
            {
                Console.Write(input[(lenght / 2) - 1]);
                Console.Write(input[lenght / 2]);
            }
            else
            {
                Console.WriteLine(input[lenght / 2]);
            }
        }
    }
}
