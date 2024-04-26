using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial__POO.Propiedades
{
    internal class JugadorMinecraft
    {
      
        private string nombre;
        private int nivelExperiencia;
        private int monedas;

      
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int NivelExperiencia
        {
            get { return nivelExperiencia; }
            set
            {
                if (value >= 0)
                    nivelExperiencia = value;
                else
                    Console.WriteLine("El nivel de experiencia no puede ser negativo");
            }
        }

        public int Monedas
        {
            get { return monedas; }
            set
            {
                if (value >= 0)
                    monedas = value;
                else
                    Console.WriteLine("La cantidad de monedas no puede ser negativa");
            }
        }
    }
}


