using Observer.Core;
using System;

namespace Observer.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pricePerDay = new double[] { 0.6, 0.5, 0.75, 0.3, 0.82 };

            Carrots carrots = new Carrots(pricePerDay[0]);

            for (int i = 1; i < pricePerDay.Length; i++)
            {
                Console.WriteLine($"--> New Price: {pricePerDay[i]}");
                carrots.PricePerPound = pricePerDay[i];
            }

        }
    }
}
