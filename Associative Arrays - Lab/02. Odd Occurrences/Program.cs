using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words) 
            {
                string currentWord = word.ToLower();
                if (counts.ContainsKey(currentWord))
                {
                    counts[currentWord]++;
                }
                else
                {
                    counts.Add(currentWord, 1);
                }
            }
            foreach (var count in counts) 
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
