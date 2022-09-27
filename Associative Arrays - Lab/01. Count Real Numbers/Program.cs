using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            SortedDictionary<int, int> stoinost = new SortedDictionary<int, int>();
            foreach (int number in numbers) 
            {
                if (stoinost.ContainsKey(number))
                {
                    stoinost[number] += 1;
                }
                else
                {
                    stoinost.Add(number, 1);
                }
            }
            foreach (var item in stoinost)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
