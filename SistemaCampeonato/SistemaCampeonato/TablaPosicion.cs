using System;
using System.Collections.Generic;

namespace SistemaCampeonato
{
    public class TablaPosicion
    {
        // Propiedad para el equipo asociado (de tipo Equipo)
        public Equipo NombreEquipo { get; set; }

        // Propiedad para los puntos del equipo
        public int Puntos { get; private set; }

        // Propiedad para los goles a favor
        public int GolesFavor { get; private set; }

        // Propiedad para los goles en contra
        public int GolesEnContra { get; private set; }

        // Constructor por defecto
        public TablaPosicion()
        {
        }

        // Constructor con parámetros
        public TablaPosicion(Equipo nombreEquipo)
        {
            NombreEquipo = nombreEquipo;
            Puntos = 0;
            GolesFavor = 0;
            GolesEnContra = 0;
        }

        // Método para actualizar la tabla con un resultado
        public void ActualizarTabla(Resultados resultado)
        {
            // Verificar si el equipo local es este equipo
            if (resultado.Partido.EquipoLocal == NombreEquipo)
            {
                GolesFavor += resultado.GolesEquipoLocal;
                GolesEnContra += resultado.GolesEquipoVisitante;
                if (resultado.EsEmpate)
                {
                    Puntos += 1; // 1 punto por empate
                }
                else if (resultado.EquipoGanador == NombreEquipo)
                {
                    Puntos += 3; // 3 puntos por victoria
                }
            }
            // Verificar si el equipo visitante es este equipo
            else if (resultado.Partido.EquipoVisitante == NombreEquipo)
            {
                GolesFavor += resultado.GolesEquipoVisitante;
                GolesEnContra += resultado.GolesEquipoLocal;
                if (resultado.EsEmpate)
                {
                    Puntos += 1; // 1 punto por empate
                }
                else if (resultado.EquipoGanador == NombreEquipo)
                {
                    Puntos += 3; // 3 puntos por victoria
                }
            }
        }

        // Método ToString para mostrar la información de la tabla de posiciones
        public override string ToString()
        {
            return $"Equipo: {NombreEquipo.NombreEquipo}, Puntos: {Puntos}, Goles a Favor: {GolesFavor}, Goles en Contra: {GolesEnContra}";
        }
    }
}
