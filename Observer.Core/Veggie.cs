using System;
using System.Collections.Generic;

namespace Observer.Core
{
    public abstract class Veggie
    {
        private double _pricePerPound;

        private Restaurant _samsSteakhouse;
        private Restaurant _iltheatro;
        private Restaurant _kuernberghalle;
        
        public Veggie(double pricePerPound)
        {
            _pricePerPound = pricePerPound;

            _samsSteakhouse = new Restaurant("Sam's Steakhouse", 0.5);
            _iltheatro = new Restaurant("Il Theatro", 0.7);
            _kuernberghalle = new Restaurant("Kürnberghalle", 0.4);
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
                PriceHasChanged();
                
            }
        }

        private void PriceHasChanged()
        {
            _samsSteakhouse.PriceHasChanged(this);
            _iltheatro.PriceHasChanged(this);
            _kuernberghalle.PriceHasChanged(this);
        }
    }
}
