﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_equipos_de_beisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo algodoneros = new Equipo("Algodoneros");
            Equipo yaquis = new Equipo("Yaquis");

            equipos.Add(algodoneros);
            equipos.Add(yaquis);

            //Estos son los algodoneros
            Jugador Alberto = new Jugador("Alberto", "06");
            Jugador Pablo = new Jugador("Pablo", "64");
            Jugador Roberto = new Jugador("Roberto", "93");
            Jugador Mario = new Jugador("Mario", "88");
            Jugador Jose = new Jugador("Jose", "76");
            Jugador Miguel = new Jugador("Miguel", "23");
            Jugador Jesus = new Jugador("Jesus", "15");
            Jugador Cleyton = new Jugador("Cleyton", "45");
            Jugador Omar = new Jugador("Omar", "66");
            //Estos son de los yaquis
            Jugador Alex = new Jugador("Alex", "08");
            Jugador Jebus = new Jugador("Jebus", "50");
            Jugador Carlos = new Jugador("Carlos", "42");
            Jugador Ruben = new Jugador("Ruben", "39");
            Jugador Mora = new Jugador("Mora", "56");
            Jugador Gerardo = new Jugador("Gerardo", "99");
            Jugador Emilio = new Jugador("Emilio", "100");
            Jugador Jonh = new Jugador("Jonh Cena", "69");
            Jugador vlad = new Jugador("Vlad", "32");

            algodoneros.jugadores.Add(Alberto);
            algodoneros.jugadores.Add(Pablo);
            algodoneros.jugadores.Add(Roberto);
            algodoneros.jugadores.Add(Mario);
            algodoneros.jugadores.Add(Jose);
            algodoneros.jugadores.Add(Miguel);
            algodoneros.jugadores.Add(Jesus);
            algodoneros.jugadores.Add(Cleyton);
            algodoneros.jugadores.Add(Omar);

            yaquis.jugadores.Add(Alex);
            yaquis.jugadores.Add(Jebus);
            yaquis.jugadores.Add(Carlos);
            yaquis.jugadores.Add(Ruben);
            yaquis.jugadores.Add(Gerardo);
            yaquis.jugadores.Add(Emilio);
            yaquis.jugadores.Add(Mora);
            yaquis.jugadores.Add(Jonh);
            yaquis.jugadores.Add(vlad);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre);
                Console.WriteLine("Lista de jugadores: ");

                foreach (Jugador jugador in equipo.jugadores)
                {
                    Console.WriteLine("Nombre: " + jugador.Nombre);
                    Console.WriteLine("Numero: " + jugador.Numero);
                }
            }

            Console.ReadLine();
        }
    }
}
