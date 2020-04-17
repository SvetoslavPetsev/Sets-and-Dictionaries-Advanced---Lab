using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main()
        {
            var shopsAndProducts = new Dictionary<string, Dictionary<string, double>>();
            string input;
            while ((input = Console.ReadLine())!= "Revision")
            {
                var info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var shop = info[0];
                var product = info[1];
                var price = double.Parse(info[2]);

                if (!shopsAndProducts.ContainsKey(shop))
                {
                    var products = new Dictionary<string, double>();
                    products.Add(product, price);
                    shopsAndProducts.Add(shop, products);
                }
                else if (!shopsAndProducts[shop].ContainsKey(product))
                {
                    shopsAndProducts[shop].Add(product, price);
                }
                else
                {
                    shopsAndProducts[shop][product] = price;
                }
            }
            foreach (var shop in shopsAndProducts.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
