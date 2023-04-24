using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int dissolver = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumNylon = (nylon + 2) * 1.50;
            double sumPaint = (paint + (paint * 10 / 100.0)) * 14.50;
            double sumDissolver = dissolver * 5.00;
            double sumMaterials = sumNylon + sumPaint + sumDissolver + 0.40;
            double sumWorkers = (sumMaterials * 30 / 100.0) * hours;
            Console.WriteLine(sumMaterials + sumWorkers);
        }
    }
}