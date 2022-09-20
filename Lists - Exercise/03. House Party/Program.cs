using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            bool flag = false;


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] split = command.Split(' ');


                if (split.Length == 3) 
                {
                    foreach (var item in list)
                    {
                        if (split[0] == item)
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine($"{split[0]} is already in the list!");
                    }
                    else
                    {
                        list.Add(split[0]);
                    }
                }
                else
                {
                    foreach (var item in list)
                    {
                        if (split[0] == item)
                        {
                            flag =  true;
                            break;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        list.Remove(split[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{split[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
        }
    }
}
