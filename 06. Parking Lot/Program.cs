using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine())!= "END")
            {
                var info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = info[0];
                string carNumber = info[1];
                if (cmd == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (cmd == "OUT")
                {
                    if (carNumbers.Contains(carNumber))
                    {
                        carNumbers.Remove(carNumber);
                    }
                }
            }
            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
