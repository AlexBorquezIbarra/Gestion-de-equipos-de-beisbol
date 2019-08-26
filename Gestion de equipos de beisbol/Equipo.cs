using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_equipos_de_beisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public Equipo ()
        {
            Nombre = "Descinocido";
            CiudadDeOrigen = "Desconocido";
            Entrenador = "Desconocido";
            Jugadores = new List<Jugador>();
        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
            ciudaddeorigen = "Desconocido";
            entrenador = "Desconocido";
            Jugadores = new List<Jugador>();
        }
    }
}
