using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Core.Contracts
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}
