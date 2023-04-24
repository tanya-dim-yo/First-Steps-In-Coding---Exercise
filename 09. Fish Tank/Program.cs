using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double volume = length * width * height;
            double liters = volume / 1000.0;
            double usedSpace = liters * percent / 100.0;
            double water = liters - usedSpace;
            Console.WriteLine(water);
        }
    }
}