using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldTesting20212
{
    public class Jugador
    {
        public Jugador(string _nombre,int _eleccion)
        {
            this.Nombre = _nombre;
            this.Eleccion = _eleccion;
        }
        public string Nombre { get; set; }
        public int Eleccion { get; set; }
    }
}
