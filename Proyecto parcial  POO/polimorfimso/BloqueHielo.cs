using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_parcial__POO.Minecraft;

namespace Proyecto_parcial__POO.polimorfimso
{
    public class BloqueHielo : Bloque, IInteractivo
    {
        public BloqueHielo(int posX, int posY, string tipo, string textura) : base(posX, posY, tipo, textura) { }

      
        public void Interactuar()
        {
            Console.WriteLine("\nEl bloque de hielo se rompio... a salido agua");
        }
    }

}
