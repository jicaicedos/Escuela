using System;
using System.Collections.Generic;

namespace Principal.Entidades
{
 
    public class Escuela
    {
        public string Nombre { get; set; }

        public List<Curso> listaCursos { get; set; }

        public Escuela(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString(){
            return $"Nombre: {Nombre}";
        }
    }
}