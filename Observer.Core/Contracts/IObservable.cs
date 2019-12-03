using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Core.Contracts
{
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
