using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_equipos_de_beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador ()
        {
            Nombre = "Jugador sin nombre";
            Numero = "Desconocido";
        }

        public Jugador (string nombre)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
