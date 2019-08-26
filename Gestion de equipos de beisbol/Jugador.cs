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
            Nombre = "No asignado";
            Numero = "No asignado";
        }

        public Jugador (string nombre)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
