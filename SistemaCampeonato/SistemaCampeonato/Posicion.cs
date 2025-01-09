using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCampeonato
{
    public class Posicion
    {
        public int Id { get; set; }

        // Propiedad para el nombre de la posición
        public string Nombre { get; set; }

        // Constructor para inicializar los atributos
        public Posicion(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // Método ToString para mostrar la posición de manera legible
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}";
        }
    }
}
