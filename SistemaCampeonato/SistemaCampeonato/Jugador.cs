using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCampeonato
{
    internal class Jugador
    {
        // Propiedad para la cédula del jugador
        public string Cedula { get; set; }

        // Propiedad para el nombre del jugador
        public string Nombre { get; set; }

        // Propiedad para el dorsal del jugador
        public int Dorsal { get; set; }

        // Propiedad para la posición del jugador (de tipo Posicion)
        public Posicion Posicion { get; set; }

        // Propiedad para el equipo del jugador
        public Equipo Equipo { get; set; }

        // Constructor para inicializar los atributos
        public Jugador(string cedula, string nombre, int dorsal, Posicion posicion, Equipo equipo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Dorsal = dorsal;
            Posicion = posicion;
            Equipo = equipo;  // Cambié 'equipo' a 'Equipo'
        }

        // Método ToString para mostrar la información del jugador de manera legible
        public override string ToString()
        {
            return $"Cédula: {Cedula}, Nombre: {Nombre}, Dorsal: {Dorsal}, Posición: {Posicion.Nombre}, Equipo: {Equipo.NombreEquipo}";  // Cambié 'Equipo' a 'Equipo.NombreEquipo'
        }
    }
}
