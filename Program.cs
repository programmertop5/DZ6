using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 14, 3, 6, -4, 5 };
            Array arr = new Array(numbers);

            Console.WriteLine("Original: " + arr);

            arr.SortAsc();
            Console.WriteLine("Sort Asc: " + arr);

            arr.SortDesc();
            Console.WriteLine("Sort Desc: " + arr);

            arr.SortByParam(true);
            Console.WriteLine("SortByParam(true): " + arr);

            arr.SortByParam(false);
            Console.WriteLine("SortByParam(false): " + arr);


            Money m = new Money(10, 50);     
            Product p = new Product("Cheeze", m);

            p.Print();                       

            p.DecreasePrice(2, 70);          

            p.Print();                       
        }
    }
}
