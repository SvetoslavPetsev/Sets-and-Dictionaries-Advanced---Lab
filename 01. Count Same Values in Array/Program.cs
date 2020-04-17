using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            var dict = new Dictionary<double, int>();
            foreach (var number in input)
            {
                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }
                dict[number]++;
            }
            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
