using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class JuegoCarreras : VideoJuego
    {
        private string TipoCarro;
        private string Pista;
        public int PuestoJugador { get; set; }

        public string tipoCarro
        {
            get { return TipoCarro; }
            set { TipoCarro = value; }
        }
        public string pista
        {
            get { return Pista; }
            set { Pista = value; }
        }
        public int Revasar(int PuestoJugador)
        {
            if (PuestoJugador <= 1)
            {
                Console.WriteLine("Usted se Encuentra en Primer Lugar");
            }
            else
            {
                PuestoJugador++;
                Console.WriteLine($"Ahora se encuentra en el Puesto Numero: {PuestoJugador}");
            }
            return PuestoJugador;
        }

    }
}
