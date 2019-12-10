using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverExamen.Observer;
using System.Collections;

namespace ObserverExamen.Subject
{
    public class Sensor : ISubject
    {
        ///Estado
        ///
        private int porcentajeBateria;
        private bool bateriaConexion;
        private bool bateriaCarga;

        ///Lista de Observers
        ///
        private readonly IList _suscriptores;

        ///Propiedades
        ///

        public int PorcentajeBateria
        {
            get => porcentajeBateria;

            // Cada vez que se modifique el estado, se invocara el metodo NotificarObservers()
            set
            {
                if (porcentajeBateria != value)
                {
                    porcentajeBateria = value;
                    NotificarObservers();
                }
            }
        }

        public bool BateriaConexion
        {
            get => bateriaConexion;
            set
            {
                if (bateriaConexion != value)
                {
                    bateriaConexion = value;
                    NotificarObservers();
                }
            }
        }

        public bool BateriaCarga
        {
            get => bateriaCarga;
            set
            {
                if (bateriaCarga != value)
                {
                    bateriaCarga = value;
                    NotificarObservers();
                }
            }
        }

        ///Metodos de ISubject
        ///
        public Sensor(int porcentajeBateria, bool bateriaConexion, bool bateriaCarga)
        {
            _suscriptores = new ArrayList();
            this.porcentajeBateria = porcentajeBateria;
            this.bateriaConexion = bateriaConexion;
            this.bateriaCarga = bateriaCarga;
        }
        public void RegistrarObserver(IObserver o)
        {
            if (!_suscriptores.Contains(o))
                _suscriptores.Add(o);
        }

        public void EliminarObserver(IObserver o)
        {
            if (_suscriptores.Contains(o))
                _suscriptores.Remove(o);
        }

        public void NotificarObservers()
        {
            int[] valores = { porcentajeBateria };
            bool[] valoresB = { bateriaConexion, bateriaCarga };

            foreach (var o in _suscriptores)
            {
                var observer = (IObserver)o;
                observer.Update(valores);
                observer.Update(valoresB);
            }
        }

    }
}
