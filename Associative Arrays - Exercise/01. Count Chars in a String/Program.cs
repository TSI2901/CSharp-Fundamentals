using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            
            Dictionary<char, int> povtorki = new Dictionary<char, int>();
            foreach (var word in words)
            {
                if (word != ' ')
                {
                    if (povtorki.ContainsKey(word))
                    {
                        povtorki[word]++;
                    }
                    else
                    {
                        povtorki.Add(word, 1);
                    }
                }
                
            }
            foreach (var item in povtorki)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
