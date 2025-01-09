using System;

namespace SistemaCampeonato
{
    public class Partidos
    {
        // Propiedad para el ID del partido
        public int IdPartido { get; set; }

        // Propiedad para el equipo local (de tipo Equipo)
        public Equipo EquipoLocal { get; set; }

        // Propiedad para el equipo visitante (de tipo Equipo)
        public Equipo EquipoVisitante { get; set; }

        // Propiedad para la fecha del partido
        public DateTime Fecha { get; set; }

        // Propiedad para la hora del partido
        public TimeSpan Hora { get; set; }

        // Constructor por defecto
        public Partidos()
        {
        }

        // Constructor con parámetros
        public Partidos(int idPartido, Equipo equipoLocal, Equipo equipoVisitante, DateTime fecha, TimeSpan hora)
        {
            IdPartido = idPartido;
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            Fecha = fecha;
            Hora = hora;
        }

        // Método ToString para mostrar la información del partido de manera legible
        public override string ToString()
        {
            return $"ID Partido: {IdPartido}, Local: {EquipoLocal.NombreEquipo}, Visitante: {EquipoVisitante.NombreEquipo}, Fecha: {Fecha:yyyy-MM-dd}, Hora: {Hora}";
        }
    }
}
