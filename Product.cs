using System;

namespace ConsoleApp5
{
    internal class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void DecreasePrice(int w, int c)
        {
            Price.Decrease(w, c);
        }

        public void Print()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }
    }
}
