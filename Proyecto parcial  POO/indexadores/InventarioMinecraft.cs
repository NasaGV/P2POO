using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial__POO.indexadores
{
    internal class InventarioMinecraft
    {
        private string[] inventario;

        public InventarioMinecraft(int capacidad)
        {
            inventario = new string[capacidad];
        }

        // Indexador para acceder a los elementos del inventario
        public string this[int indice]
        {
            get
            {
                if (indice < 0 || indice >= inventario.Length)
                    throw new IndexOutOfRangeException("El índice está fuera de rango");
                return inventario[indice];
            }
            set
            {
                if (indice < 0 || indice >= inventario.Length)
                    throw new IndexOutOfRangeException("El índice está fuera de rango");
                inventario[indice] = value;
            }
        }
    }
}


