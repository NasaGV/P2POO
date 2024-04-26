using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial__POO.Minecraft
{
    public class BloqueAgua : Bloque
    {
        public bool Transparente { get; set; }
        public int Profundidad { get; set; }

        // Constructor
        public BloqueAgua(int posX, int posY, bool transparente, int profundidad)
            : base("Agua", "TexturaAgua", posX, posY)
        {
            Transparente = transparente;
            Profundidad = profundidad;
        }

        // Metodo para expandir el agua
        public void Expandir()
        {
            Profundidad++;
            Console.WriteLine("El bloque de agua se esta expandiendo.");
        }
    }

}
