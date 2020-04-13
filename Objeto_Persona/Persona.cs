using System;
using System.Collections.Generic;
using System.Text;

namespace Objeto_Persona
{
    public class Persona
    {

        public string nombre;
        public int edad;
        public int altura;
        public int peso;
        public string nacionalidad;
        public int hijos = 0;


        public Persona(string nombreConstructor, int edadConstructor, int alturaConstructor)
        {
            nombre = nombreConstructor;
            edad = edadConstructor;
            altura = alturaConstructor;
        }

        public Persona()
        {

        }


    }
}
