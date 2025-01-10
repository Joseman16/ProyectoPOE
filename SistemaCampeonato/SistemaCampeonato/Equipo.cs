using System;
using System.Collections.Generic;

namespace SistemaCampeonato
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreFacultad { get; set; }

        // Lista de jugadores que pertenece a este equipo
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();

        public Equipo() { }

        public Equipo(string nombreEquipo, string nombreFacultad)
        {
            NombreEquipo = nombreEquipo;
            NombreFacultad = nombreFacultad;
        }

        public Equipo(int idEquipo, string nombreEquipo, string nombreFacultad)
        {
            IdEquipo = idEquipo;
            NombreEquipo = nombreEquipo;
            NombreFacultad = nombreFacultad;
        }

        public override string ToString()
        {
            return $"ID: {IdEquipo}, Nombre: {NombreEquipo}, Facultad: {NombreFacultad}";
        }
    }
}
