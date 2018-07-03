using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Examen
{
    public partial class Form1 : Form
    {
        Thread th;
        public string nombre;
        public int puntaje;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            this.Close();
            th = new Thread(openJuego);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openPuntaje);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openJuego()
        {
            Application.Run(new PantallaJuego(nombre, puntaje));
        }
        private void openPuntaje()
        {
            Application.Run(new Puntajes("",0));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
