using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatWord(word, n);
        }

        static void RepeatWord(string word, int NumberOfRepeating) 
        {
            for (int i = 0; i < NumberOfRepeating; i++)
            {
                Console.Write(word);
            }
        }
    }
}
