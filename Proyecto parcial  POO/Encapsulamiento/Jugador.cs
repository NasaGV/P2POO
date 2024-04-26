using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_parcial__POO.Encapsulamiento
{

    public class Jugador
    {
        private string nombre;
        private int puntosDeVida;
        private int nivel;

        // Constructor
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            this.puntosDeVida = 20;
            this.nivel = 1;
        }

        // Métodos para acceder y modificar los atributos encapsulados

        public void setNombre (string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre ()
        {
            return nombre;
        }
        public void setVida(int nuevaVida)
        {
            this.puntosDeVida = nuevaVida;
        }

        public int getVida()
        {
            return puntosDeVida;
        }

        public void setNivel(int nuevoNivel)
        {
            this.nivel = nuevoNivel;
        }

        public int getNivel()
        {
            return nivel;
        }

    }
}