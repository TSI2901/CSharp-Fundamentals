using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> sinonimi = new Dictionary<string, List<string>>();
            for (int i = 0; i <  n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();
                if (sinonimi.ContainsKey(word))
                {
                    sinonimi[word].Add(sinonim);
                }
                else
                {
                    List<string> sssss = new List<string>();
                    sssss.Add(sinonim);
                    sinonimi.Add(word, sssss);
                }
            }
            foreach (var item in sinonimi)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
