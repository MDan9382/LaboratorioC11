using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    /// <summary>
    /// Esta Clase Padre tiene 4 errores lógicos
    /// debe de encontrarlos y corregirlos
    /// documente los errores encontrados y las correcciones realizadas
    /// </summary>
    internal class VideoJuego
    {
        private string titulo;
        private string desarrolladora;
        private double calificacion;
        private int anioLanzamiento;
        private bool jugando;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Desarrolladora
        {
            get { return desarrolladora; }
            set { desarrolladora = value; }
        }

        public double Calificacion
        {
            get { return calificacion; }
            set
            {
                //  La calificación debe estar entre 0 y 10
                if (value >= 0 || value <= 10) // corregido de "if (value < 0 || value > 10)" a "if (value >= 0 || value <= 10)"
                {
                    calificacion = value;
                } else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 10");
                }
                    
            }
        }

        public int AnioLanzamiento
        {
            get { return anioLanzamiento; }
            set
            {
                // Error lógico: El año de lanzamiento 
                if (anioLanzamiento <= 1950 || anioLanzamiento >= 2024)
                {
                    Console.WriteLine("anio de lanzamiento invalido, el anio de lanzamiento se debe encontrar entre 1950 y 2024");
                }
                else
                {
                    anioLanzamiento = value;
                }
                //agregado un limite inferior y superior para el lanzamiento
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Desarrolladora: " + Desarrolladora);
            Console.WriteLine("Calificación: " + Calificacion);
            Console.WriteLine("Año de Lanzamiento: " + AnioLanzamiento);
        }

        public static void saludo(string nom)
        {
            Console.WriteLine($"Hi Gamer: {nom}");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
            int pausa = false;
        }

        public bool DetenerPartida(int n) //pausa
        {

            // Error lógico

            // estado de pausa creado
            if (n == false) //si el juego no esta pausado lo detiene
            {
                jugando = false;
                Console.WriteLine("Partida detenida.");
                n = true;
            }
            else // si el juego esta pausado lo reanudara
            {
                jugando = true;
                Console.WriteLine("Partida reanudada");
                n = false;
            }
            return n;
            
        }

        public void TerminarJuego()
        {
            // Error lógico
            if (jugando==true || jugando==false && pausa==true) //agregada condicion logica
            {
                jugando = false;
                Console.WriteLine("Juego terminado."); 
                //agregado jugando = false;
            }
            else
            {
                Console.WriteLine("No hay partida en curso.");
            }
        }

    }
}
