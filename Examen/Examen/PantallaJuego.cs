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
using ClassExamen;

namespace Examen
{
    public partial class PantallaJuego : Form
    {
        Thread th;

        public Random rnd = new Random();
        Pacman pacman = new Pacman { movimiento = "LEFT" };

        public int _x = 267;

        public string nombre;
        public int puntaje;
        public int tiempo1, tiempo2;
        

        public Point newobject()
        {
            int i = rnd.Next(0, 21);
            int x = 7 + 26 * i;
            int j = rnd.Next(0, 15);
            int y = 33 + 26 * j;
            return new Point(x, y);
        }
        
        public PantallaJuego(string _nombre, int _puntaje)
        {
            InitializeComponent();
            PB_FantasmaRojo.Location = newobject();
            PB_FantasmaRosa.Location = newobject();
            nombre = _nombre;
            puntaje = _puntaje;
        }


        public Point Movimiento(string direccion, int x, int y)
        {
            if (direccion == "LEFT")
            {
                x -= 26;
                if (x < 7)
                {
                    return new Point(x+26, y);
                }
                return new Point(x, y);
            }
            else if (direccion == "RIGHT")
            {
                x += 26;
                if (x>527)
                {
                    return new Point(x-26,y);
                }
                return new Point(x, y);
            }
            else if (direccion == "UP")
            {
                y -= 26;
                if (y < 33)
                {
                    return new Point(x, y + 26);
                }
                return new Point(x, y);
            }
            else if (direccion == "DOWN")
            {
                y += 26;
                if (y > 397)
                {
                    return new Point(x, y-26);
                }
                return new Point(x, y);
            }
            else
            {
                return new Point(x, y);
            }
        }

        public string movimientoFantasma(int x_f, int y_f, int x_p, int y_p)
        {
            int distX = x_f - x_p;
            int distY = y_f - y_p;
            if (Math.Abs(distX) < Math.Abs(distY))
            {
                if (distY < 0)
                {
                    return "DOWN";
                }
                else
                {
                    return "UP";
                }
            }
            else
            {
                if (distX < 0)
                {
                    return "RIGHT";
                }
                else
                {
                    return "LEFT";
                }
            }
            

        }

        public bool checkGameOver(int x_f, int y_f, int x_p, int y_p)
        {
            if (x_f == x_p && y_f == y_p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo1 += 1;
            tiempo2 += 1;
            label2.Text = tiempo1.ToString();
            PB_Pacman.Location = Movimiento(pacman.movimiento, PB_Pacman.Location.X, PB_Pacman.Location.Y);
            PB_FantasmaRojo.Location = Movimiento(movimientoFantasma(PB_FantasmaRojo.Location.X, PB_FantasmaRojo.Location.Y, PB_Pacman.Location.X, PB_Pacman.Location.Y),PB_FantasmaRojo.Location.X, PB_FantasmaRojo.Location.Y);
            PB_FantasmaRosa.Location = Movimiento(movimientoFantasma(PB_FantasmaRosa.Location.X, PB_FantasmaRosa.Location.Y, PB_Pacman.Location.X, PB_Pacman.Location.Y),PB_FantasmaRosa.Location.Y, PB_FantasmaRosa.Location.Y);
            if (checkGameOver(PB_FantasmaRojo.Location.X, PB_FantasmaRojo.Location.Y, PB_Pacman.Location.X, PB_Pacman.Location.Y))
            {
                timer1.Stop();
                MessageBox.Show("FIN DEL JUEGO \nPuntaje: {0}",puntaje.ToString());
                this.Close();
                th = new Thread(openPuntaje);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if (checkGameOver(PB_FantasmaRosa.Location.X, PB_FantasmaRosa.Location.Y, PB_Pacman.Location.X, PB_Pacman.Location.Y))
            {
                timer1.Stop();
                MessageBox.Show("FIN DEL JUEGO \nPuntaje: {0}", puntaje.ToString());
                this.Close();
                th = new Thread(openPuntaje);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            if ((tiempo1 % 10) == 0)
            {
                if (rnd.Next(0, 2) == 1)
                {
                    PB_Cherry.Visible = true;
                    PB_Cherry.Location = newobject();
                }
                else
                {
                    PB_Pear.Visible = true;
                    PB_Pear.Location = newobject();
                }
            }
            if ((tiempo2 % 5) == 0)
            {
                PB_Cherry.Visible = false;
                PB_Pear.Visible = false;
            }
            
        }

        private void PantallaJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                pacman.movimiento = "LEFT";
                PB_Pacman.Image = Properties.Resources.pacman_left;
            }
            if (e.KeyData == Keys.Right)
            {
                pacman.movimiento = "RIGHT";
                PB_Pacman.Image = Properties.Resources.pacman_right;

            }
            if (e.KeyData == Keys.Up)
            {
                pacman.movimiento = "UP";
                PB_Pacman.Image = Properties.Resources.pacman_up;

            }
            if (e.KeyData == Keys.Down)
            {
                pacman.movimiento = "DOWN";
                PB_Pacman.Image = Properties.Resources.pacman_down;
            }
        }

        private void openPuntaje()
        {
            Application.Run(new Puntajes(nombre, puntaje));
        }
    }
}
