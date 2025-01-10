using System.Collections.Generic;

namespace SistemaCampeonato
{
    public static class PosicionesPredeterminadas
    {
        // Lista estática con las posiciones predeterminadas
        public static List<Posicion> ListaPosiciones { get; } = new List<Posicion>
        {
            new Posicion(1, "Arquero"),
            new Posicion(2, "Defensa Central"),
            new Posicion(3, "Lateral Izquierdo"),
            new Posicion(4, "Lateral Derecho"),
            new Posicion(5, "Mediocampista"),
            new Posicion(6, "Extremo Izquierdo"),
            new Posicion(7, "Extremo Derecho"),
            new Posicion(8, "Delantero")
        };
    }
}
