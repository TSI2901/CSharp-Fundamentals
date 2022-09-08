using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string incomingComands = Console.ReadLine();
            while (incomingComands != "end")
            {
                string[] split = incomingComands.Split(" ");
                if (split[0] == "Add")
                {
                    wagons.Add(int.Parse(split[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (capacity >= (int.Parse(split[0]) + wagons[i]))
                        {
                            wagons[i] += int.Parse(split[0]);
                            break;
                        }
                    }
                }
                incomingComands = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
