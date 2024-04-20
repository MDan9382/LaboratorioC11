using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoDeportes : VideoJuego
    {
        private string Deporte;
        private string NombreEquipo;
        private int NumJugadores;

        public string deportes
        {
            get { return Deporte; }
            set { deportes = value; }
        }

        public string nombreEquipo
        {
            get { return NombreEquipo; }
            set { NombreEquipo = value; }
        }
        public int numJugadores
        {
            get { return NumJugadores; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Numero invalido de Jugadores");
                }
                else
                {
                    NumJugadores = value;
                }
            }
        }
        public void ConectarOnline()
        {
            Console.WriteLine("Comprobano Coneccion a Internet...");
            Console.WriteLine("Conectado Exitosamente");
        }

    }
}
