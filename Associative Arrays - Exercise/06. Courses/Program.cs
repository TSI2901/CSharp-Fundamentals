using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "end") 
            {
                if (!dic.ContainsKey(command[0]))
                {
                    List<string> list = new List<string>();
                    list.Add(command[1]);
                    dic.Add(command[0], list);
                }
                else
                {
                    dic[command[0]].Add(command[1]);
                }
                command = Console.ReadLine().Split(" : ");
            }
            foreach (var key in dic) 
            {
                List<string> ggg = key.Value;
                Console.WriteLine($"{key.Key}: {ggg.Count}");
                foreach (var item in ggg) 
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
