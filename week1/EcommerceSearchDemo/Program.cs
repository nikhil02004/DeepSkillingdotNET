using System;

namespace EcommerceSearchDemo
{
    class Program
    {
        static void Main()
        {
            Product[] products = {
                new Product(101, "Keyboard", "Electronics"),
                new Product(102, "Laptop", "Electronics"),
                new Product(103, "Mouse", "Electronics"),
                new Product(104, "Notebook", "Stationery"),
                new Product(105, "Pen", "Stationery")
            };

            Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));

            Console.WriteLine("Binary Search for 'Mouse':");
            int index = SearchDemo.BinarySearch(products, "Mouse");
            Console.WriteLine(index >= 0 ? products[index].ToString() : "Not found");

            Console.WriteLine("\nLinear Search for 'Pen':");
            index = SearchDemo.LinearSearch(products, "Pen");
            Console.WriteLine(index >= 0 ? products[index].ToString() : "Not found");
        }
    }
}
