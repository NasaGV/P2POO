using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial__POO.Minecraft
{
    public class Bloque
    {
        private int posX;
        private int posY;
        private string v;

        public string Tipo { get; set; }
        public string Textura { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        // Constructor
        public Bloque(string tipo, string textura, int posX, int posY)
        {
            Tipo = tipo;
            Textura = textura;
            PosicionX = posX;
            PosicionY = posY;
        }

        public Bloque(int posX, int posY, string tipo, string textura)
        {
            this.posX = posX;
            this.posY = posY;
            Tipo = tipo;
            Textura = textura;
        }

        public Bloque(string v, int posX, int posY, string textura)
        {
            this.v = v;
            this.posX = posX;
            this.posY = posY;
            Textura = textura;
        }

        // Método para colocar el bloque
        public void Colocar()
        {
            Console.WriteLine($"Se colocó un bloque de tipo {Tipo} en la posición ({PosicionX}, {PosicionY}).");
        }
    }


}
