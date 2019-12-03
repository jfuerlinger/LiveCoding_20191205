using Observer.Core.Contracts;
using System;
using System.Collections.Generic;

namespace Observer.Core
{
    public abstract class Veggie : IObservable
    {
        private double _pricePerPound;

        private List<IObserver> _observers;

        public Veggie(double pricePerPound)
        {
            _pricePerPound = pricePerPound;

            _observers = new List<IObserver>();
         
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
                Notify();

            }
        }


        public void Notify()
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Attach(IObserver observer)
        {
            if(!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if(_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

    }
}
