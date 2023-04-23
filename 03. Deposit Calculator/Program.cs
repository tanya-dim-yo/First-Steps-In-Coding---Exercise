using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            double sum = depositedSum + period * ((depositedSum * rate / 100) / 12);
            Console.WriteLine(sum);
        }

    }
}
