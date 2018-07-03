using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassExamen;
using System.Threading;

namespace Examen
{
    public partial class Puntajes : Form
    {
        Thread th;
        string nombre;
        int puntaje;
        static List<Juego> PuntajeHistorico = new List<Juego>();
        public Puntajes(string _nombre, int _puntaje)
        {
            InitializeComponent();
            nombre = _nombre;
            puntaje = _puntaje;
            Juego a = new Juego { nombre = nombre, puntaje = puntaje };
            if (a.nombre != "" && a.puntaje != 0)
            { 
                PuntajeHistorico.Add(a);
            }
            foreach (Juego j in PuntajeHistorico)
            {
                listBox1.Items.Add(j.nombre);
                listBox2.Items.Add(j.puntaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPrincipal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openPrincipal()
        {
            Application.Run(new Form1());
        }
    }
}
