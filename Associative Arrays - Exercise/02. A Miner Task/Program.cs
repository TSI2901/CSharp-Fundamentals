using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mina = new Dictionary<string, int>();
            string vid = Console.ReadLine();
            while (vid != "stop") 
            {
                int num = int.Parse(Console.ReadLine());
                if (mina.ContainsKey(vid))
                {
                    mina[vid] += num;
                }
                else
                {
                    mina.Add(vid, num);
                }
                vid = Console.ReadLine();
            }
            foreach (var item in mina) 
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
