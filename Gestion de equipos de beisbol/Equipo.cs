using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_equipos_de_beisbol
{
    class Equipo
    {
        public string Nombre;
        public string ciudaddeorigen;
        public string entrenador;
        public List<Jugador> jugadores;

        public Equipo ()
        {
            Nombre = "Desconocido";
            ciudaddeorigen = "Desconocido";
            entrenador = "Desconocido";
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            ciudaddeorigen = "Desconocido";
            entrenador = "Desconocido";
            jugadores = new List<Jugador>();
        }
    }
}
