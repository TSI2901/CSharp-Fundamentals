﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Vowels_Sum
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int sume = 0;
            int sumi = 0;
            int sumo = 0;
            int sumu = 0;
            string s = Console.ReadLine().ToLower();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i] == 'a')
                    suma++;
                else if (s[i] == 'e')
                    sume += 1;
                else if (s[i] == 'i')
                    sumi += 1;
                else if (s[i] == 'o')
                    sumo += 1;
                else if (s[i] == 'u')
                    sumu += 1;
            }
            int ResultSum = suma + sume + sumi + sumo + sumu;
            Console.WriteLine(ResultSum);
        }
    }
}