using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            string commands = Console.ReadLine();
            while (commands != "end")
            {
                string[] split = commands.Split(" ");
                if (split[0] == "Delete")
                {
                    numbers.Remove(double.Parse(split[1]));
                }
                if (split[0] == "Insert")
                {
                    numbers.Insert(int.Parse(split[2]), double.Parse(split[1]));
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
