using System;

namespace SistemaCampeonato
{
    // Clase para representar la posición en la tabla
    public class TablaPosicion
    {
        public Equipo Equipo { get; set; }
        public int Puntos { get; set; }
        public int GolesFavor { get; set; }
        public int GolesEnContra { get; set; }

        public TablaPosicion(Equipo equipo)
        {
            Equipo = equipo;
            Puntos = 0;
            GolesFavor = 0;
            GolesEnContra = 0;
        }

        // Método para actualizar los datos de la tabla de posiciones
        public void ActualizarTabla(Resultados resultado)
        {
            if (resultado.Partido.EquipoLocal.IdEquipo == Equipo.IdEquipo)
            {
                GolesFavor += resultado.GolesEquipoLocal;
                GolesEnContra += resultado.GolesEquipoVisitante;

                if (resultado.GolesEquipoLocal > resultado.GolesEquipoVisitante)
                {
                    Puntos += 3; // 3 puntos por victoria
                }
                else if (resultado.GolesEquipoLocal == resultado.GolesEquipoVisitante)
                {
                    Puntos += 1; // 1 punto por empate
                }
            }
            else if (resultado.Partido.EquipoVisitante.IdEquipo == Equipo.IdEquipo)
            {
                GolesFavor += resultado.GolesEquipoVisitante;
                GolesEnContra += resultado.GolesEquipoLocal;

                if (resultado.GolesEquipoVisitante > resultado.GolesEquipoLocal)
                {
                    Puntos += 3; // 3 puntos por victoria
                }
                else if (resultado.GolesEquipoVisitante == resultado.GolesEquipoLocal)
                {
                    Puntos += 1; // 1 punto por empate
                }
            }
        }

        public override string ToString()
        {
            return $"{Equipo.NombreEquipo} - Puntos: {Puntos}, Goles a favor: {GolesFavor}, Goles en contra: {GolesEnContra}";
        }
    }
}
