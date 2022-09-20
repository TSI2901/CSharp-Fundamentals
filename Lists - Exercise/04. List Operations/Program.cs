using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] split = command.Split(" ");
                if (split[0] == "Add")
                {
                    list.Add(int.Parse(split[1]));
                }
                if (split[0] == "Remove")
                {
                    if (int.Parse(split[1]) >= 0 && int.Parse(split[1]) <= list.Count - 1)
                    {
                        list.Remove(list[int.Parse(split[1])]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                if (split[0] == "Insert")
                {
                    if (int.Parse(split[2]) >= 0 && int.Parse(split[2]) <= list.Count - 1)
                    {
                        list.Insert(int.Parse(split[2]), int.Parse(split[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                    
                }
                if (split[0] == "Shift")
                {
                    if (split[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(split[2]); i++)
                        {
                            list.Add(list[0]);
                            list.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(split[2]); i++)
                        {

                            list.Insert(0, list[list.Count - 1]);
                            list.RemoveAt(list.Count - 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
