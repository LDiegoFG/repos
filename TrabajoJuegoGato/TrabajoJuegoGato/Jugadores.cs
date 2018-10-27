using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoJuegoGato
{
    public class Jugadores
    {
        public int TurnoJugador { get; set; }
        public int Turnos { get; set; }
        public int PuntosJ1 { get; set; }
        public int PuntosJ2 { get; set; }
        public int Empates { get; set; }


        public void NuevoJuego()
        {

        }

        public bool ChecarEmpate()
        {
            return true;
        }

        public bool ChecarGanador()
        {
            return true;
        }


    }
}
