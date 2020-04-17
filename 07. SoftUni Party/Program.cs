using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length == 8)
                {
                    bool isVip = Char.IsDigit(input[0]);
                    if (isVip)
                    {
                        vip.Add(input);
                    }
                    else
                    {
                        regular.Add(input);
                    }
                }
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (vip.Contains(input))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
            }
            var sum = vip.Count + regular.Count;
            Console.WriteLine(sum);
            foreach (var num in vip)
            {
                Console.WriteLine(num);
            }
            foreach (var num in regular)
            {
                Console.WriteLine(num);
            }
        }
    }
}
