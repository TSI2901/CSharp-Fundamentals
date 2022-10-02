using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> StudentGrade = new Dictionary<string,List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!StudentGrade.ContainsKey(name))
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);
                    StudentGrade.Add(name,grades);
                }
                else
                {
                    StudentGrade[name].Add(grade);
                }
            }
            foreach (var item in StudentGrade)
            {
                
                List<double> ggg = item.Value;
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
