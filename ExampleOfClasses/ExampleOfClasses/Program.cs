using System;

namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Name = "Nintendo Switch";
            var name = product.Name;
            product.Price = 299.99;
            var price = product.Price;
            Console.WriteLine($"${price} {name}");
        }
    }
}
