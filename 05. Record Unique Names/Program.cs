using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main()
        {
            HashSet<string> uniqeNames = new HashSet<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();
                uniqeNames.Add(name);
            }
            foreach (var name in uniqeNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
