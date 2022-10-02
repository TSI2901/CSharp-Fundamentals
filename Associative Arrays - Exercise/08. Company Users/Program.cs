using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            string[] command = Console.ReadLine().Split(" -> ");
            while (command[0] != "End") 
            {
                if (!map.ContainsKey(command[0]))
                {
                    List<string> list = new List<string>();
                    list.Add(command[1]);
                    map.Add(command[0], list);
                }
                if (!map[command[0]].Contains(command[1]))
                {
                    map[command[0]].Add(command[1]);
                }
                //else
                //{
                //    List<string>  sss = map[command[0]];
                //    foreach (var value in sss)
                //    {
                //        if (value == command[1])
                //        {
                            
                //            break;
                //        }
                //        else
                //        {
                //            map[command[0]].Add(command[1]);
                //            break;
                //        }
                //    }
                //}
                command = Console.ReadLine().Split(" -> ");
            }
            foreach (var item in map) 
            {
                Console.WriteLine(item.Key);
                foreach (var value in item.Value) 
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
