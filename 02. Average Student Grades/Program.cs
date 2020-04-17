using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            var studentsAndGrade = new Dictionary<string, List<decimal>>();
            var numberInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                var info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = info[0];
                var grade = decimal.Parse(info[1]);
                if (!studentsAndGrade.ContainsKey(name))
                {
                    studentsAndGrade.Add(name, new List<decimal>());
                }
                studentsAndGrade[name].Add(grade);
            }
            foreach (var (key, value) in studentsAndGrade)
            {
                decimal avrGrade = value.Average();
                Console.Write($"{key} -> ");
                foreach (var grade in value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {avrGrade:F2})");
            }
        }
    }
}
