﻿using System;

namespace VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = pages / pagesPerHour;
            int hoursPerDay = hours / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}