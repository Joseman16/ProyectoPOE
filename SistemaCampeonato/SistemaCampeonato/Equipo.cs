using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCampeonato
{
    public class Equipo
    {
        // Propiedades de la clase
        public int IdEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreFacultad { get; set; }

        // Constructor por defecto
        public Equipo()
        {
        }

        // Constructor con parámetros
        public Equipo(int idEquipo, string nombreEquipo, string nombreFacultad)
        {
            IdEquipo = idEquipo;
            NombreEquipo = nombreEquipo;
            NombreFacultad = nombreFacultad;
        }

        // Método para mostrar información del equipo
        public override string ToString()
        {
            return $"ID: {IdEquipo}, Nombre: {NombreEquipo}, Facultad: {NombreFacultad}";
        }
    }
}