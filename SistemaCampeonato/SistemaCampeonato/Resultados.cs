using System;

namespace SistemaCampeonato
{
    public class Resultados
    {
        // Propiedad para el ID del resultado
        public int Id { get; set; }

        // Propiedad para el partido asociado (de tipo Partidos)
        public Partidos Partido { get; set; }

        // Propiedad para los goles del equipo local
        public int GolesEquipoLocal { get; set; }

        // Propiedad para los goles del equipo visitante
        public int GolesEquipoVisitante { get; set; }

        // Propiedad booleana para indicar si el resultado es empate
        public bool EsEmpate { get; private set; }

        // Propiedad para el equipo ganador (de tipo Equipo)
        public Equipo EquipoGanador { get; private set; }

        // Constructor por defecto
        public Resultados()
        {
        }

        // Constructor con parámetros
        public Resultados(int id, Partidos partido, int golesEquipoLocal, int golesEquipoVisitante)
        {
            Id = id;
            Partido = partido;
            GolesEquipoLocal = golesEquipoLocal;
            GolesEquipoVisitante = golesEquipoVisitante;
            CalcularResultado();
        }

        // Método para calcular si es empate y determinar el equipo ganador
        private void CalcularResultado()
        {
            if (GolesEquipoLocal == GolesEquipoVisitante)
            {
                EsEmpate = true;
                EquipoGanador = null; // No hay ganador en caso de empate
            }
            else
            {
                EsEmpate = false;
                EquipoGanador = GolesEquipoLocal > GolesEquipoVisitante
                    ? Partido.EquipoLocal
                    : Partido.EquipoVisitante;
            }
        }

        // Método ToString para mostrar la información del resultado de manera legible
        public override string ToString()
        {
            string resultado = $"Partido ID: {Partido.IdPartido}, Local: {Partido.EquipoLocal.NombreEquipo} {GolesEquipoLocal} - {GolesEquipoVisitante} {Partido.EquipoVisitante.NombreEquipo}";
            resultado += EsEmpate
                ? ", Resultado: Empate"
                : $", Ganador: {EquipoGanador.NombreEquipo}";
            return resultado;
        }
    }
}
