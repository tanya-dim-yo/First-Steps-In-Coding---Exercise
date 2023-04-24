using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int fee = int.Parse(Console.ReadLine());
            double snickers = fee - (fee * 40 / 100.0);
            double equipment = snickers - (snickers * 20 / 100.0);
            double ball = equipment / 4;
            double accessories = ball / 5;
            double expenses = fee + snickers + equipment + ball + accessories;
            Console.WriteLine(expenses);
        }
    }
}