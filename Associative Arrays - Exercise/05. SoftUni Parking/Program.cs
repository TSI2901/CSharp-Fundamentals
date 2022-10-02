using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,string> Parking = new Dictionary<string,string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                if (command[0] == "register")
                {
                    if (!Parking.ContainsKey(command[1]))
                    {
                        Parking.Add(command[1], command[2]);
                        Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {Parking[command[1]]}");
                    }
                }
                else if (command[0] == "unregister")
                {
                    if (Parking.ContainsKey(command[1]))
                    {
                        Parking.Remove(command[1]);
                        Console.WriteLine($"{command[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {command[1]} not found");
                    }
                }
            }
            foreach (var key in Parking) 
            {
                Console.WriteLine($"{key.Key} => {key.Value}");
            }
        }
    }
}
