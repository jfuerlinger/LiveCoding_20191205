using Observer.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Core
{
    public class Restaurant : IObserver
    {
        private readonly string _name;
        private readonly double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(IObservable observable)
        {
            Veggie veggie = (Veggie)observable;

            if (veggie.PricePerPound <= _purchaseThreshold)
            {
                Console.WriteLine($"{_name}: I'll by some Carrots to the price of {veggie.PricePerPound}");
            }
        }

    }
}
