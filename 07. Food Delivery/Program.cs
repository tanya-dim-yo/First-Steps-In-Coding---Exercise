using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMeals = int.Parse(Console.ReadLine());
            int fishMeals = int.Parse(Console.ReadLine());
            int vegMeals = int.Parse(Console.ReadLine());
            double sumChickenMeals = chickenMeals * 10.35;
            double sumFishMeals = fishMeals * 12.40;
            double sumVegMeals = vegMeals * 8.15;
            double sumMeals = sumChickenMeals + sumFishMeals + sumVegMeals;
            double sumDessert = sumMeals * 20 / 100.0;
            double totalSum = sumMeals + sumDessert + 2.50;
            Console.WriteLine(totalSum);
        }
    }
}