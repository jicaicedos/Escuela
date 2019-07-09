using System;

namespace Principal.Entidades
{
 
    public class Escuela
    {
        public string Nombre { get; set; }

        public Escuela(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString(){
            return $"Nombre: {Nombre}";
        }
    }
}