using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int penPackages = int.Parse(Console.ReadLine());
            int markerPackages = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());
            double sum = (penPackages * 5.80) + (markerPackages * 7.20) + (boardCleaner * 1.20);
            double discount = sum * (discountPercentage / 100.0);
            double totalSum = sum - discount;
            Console.WriteLine(totalSum);
        }
    }
}