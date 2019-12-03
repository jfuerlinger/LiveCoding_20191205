using System;
using System.Collections.Generic;

namespace Observer.Core
{
    public abstract class Veggie
    {
        private double _pricePerPound;

        public Veggie(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public double PricePerPound
        {
            get
            {
                return _pricePerPound;
            }
            set
            {
                _pricePerPound = value;
            }
        }
    }
}
