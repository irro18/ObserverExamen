using ObserverExamen.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExamen.Subject
{
    public interface ISubject
    {
        void RegistrarObserver(IObserver o);

        void EliminarObserver(IObserver o);

        void NotificarObservers();

    }
}
