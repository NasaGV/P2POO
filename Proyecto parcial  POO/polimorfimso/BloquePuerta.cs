using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_parcial__POO.Minecraft;

namespace Proyecto_parcial__POO.polimorfimso
{
    public class BloquePuerta : Bloque, IInteractivo
    {
        public BloquePuerta(int posX, int posY, string textura) 
            :base("Puerta", posX, posY, textura) { }

        
        public void Interactuar()
        {
            Console.WriteLine("\nAbriendo o cerrando la puerta...");
        }
    }



}
