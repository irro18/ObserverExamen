using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverExamen.Observer;
using ObserverExamen.Subject;
using System.Timers;

namespace ObserverExamen
{
    public partial class Form1 : Form
    {
        private readonly ISubject _sensores;
        private IObserver _display;
        public Form1()
        {
            InitializeComponent();
            
            _sensores = new Sensor((int)numericUpDown1.Value, (bool)comboBox1.SelectedItem, (bool)comboBox2.SelectedItem);
            //_sensores = new Sensor((bool)comboBox1.SelectedItem);
            //_sensores = new Sensor((bool)comboBox2.SelectedItem);
            _display = new ObserverAlerta(_sensores);
        }

        //Timer ActualizaCargaAutomatica = new Timer();
        //ActualizarCarga 

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ((Sensor)_sensores).PorcentajeBateria = (int)numericUpDown1.Value;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Sensor)_sensores).BateriaConexion = (bool)comboBox1.SelectedItem;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((Sensor)_sensores).BateriaCarga = (bool)comboBox2.SelectedItem;
        }

        private void MonitorearBoton_Click(object sender, EventArgs e)
        {
            _display = new ObserverAlerta(_sensores);
            monitorearBoton.Enabled = false;
            stopMonitorBoton.Enabled = true;
        }

        private void StopMonitorBoton_Click(object sender, EventArgs e)
        {
            _sensores.EliminarObserver(_display);
            monitorearBoton.Enabled = true;
            stopMonitorBoton.Enabled = false;
        }
    }
}
