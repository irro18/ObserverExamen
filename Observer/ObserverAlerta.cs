using ObserverExamen.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverExamen.Observer
{
    public class ObserverAlerta : IObserver
    {
        ///COnstantes
        ///
        private static readonly int MIN_Bateria = 0;
        private static readonly int MAX_Bateria = 100;

        private static readonly bool Bateria_Conectada = true;
        private static readonly bool Bateria_Desconectada = false;

        private static readonly bool Bateria_Cargando = true;
        private static readonly bool Bateria_NoCargando = false;

        private int porcentajeBateria;
        private bool BateriaConexion;
        private bool BateriaCarga;

        //SUbject
        ///

        private ISubject subject;


        ///Constructores
        ///
        public ObserverAlerta(ISubject subject)
        {
            this.subject = subject;
            subject.RegistrarObserver(this);
        }

        ///Metodos de IObserver
        ///

        public void Update(object o)
        {
            int[] arrayInt = null;
            if (o.GetType() == typeof(int[]))
                arrayInt = (int[])o;

            bool[] arrayBool = null;
            if (o.GetType() == typeof(bool[]))
                arrayBool = (bool[])o;

            if ((arrayInt != null) && (arrayInt.Length == 3))
            {
                porcentajeBateria = arrayInt[0];
                BateriaConexion = arrayBool[0];
                BateriaCarga = arrayBool[1];

                // Comprobamos que los valores no exceden los limites
                ComprobarBateria();
                ComprobarConexion();
                ComprobarCargando();
            }

        }

        ///Comprobar
        ///

        private void ComprobarBateria()
        {
            if (porcentajeBateria <= MIN_Bateria)
            {
                MessageBox.Show($"La batería se apagará pronto. Actual: {porcentajeBateria}/{MIN_Bateria}");
            }
            if (porcentajeBateria >= MAX_Bateria )
            {
                MessageBox.Show($"La batería tiene buena carga. Actual: {porcentajeBateria}/{MAX_Bateria}");
            }
        }

        private void ComprobarConexion()
        {
            if (BateriaConexion == true)
            {
                MessageBox.Show("La Bateria está conectada.");
            }
            if (BateriaConexion == false)
            {
                MessageBox.Show("La Batería está desconectada.");
            }
        }

        private void ComprobarCargando()
        {
            if (BateriaCarga == true)
            {
                MessageBox.Show("La Batería se está cargando.");
            }
            if (BateriaCarga == false)
            {
                MessageBox.Show("La Batería no está cargando.");
            }
        }

    }
}
