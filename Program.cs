using System;
using static System.Console;
using Principal.Entidades;

namespace Principal
{
    class Program
    {
        // public Curso[] cursos;

        static void Main(string[] args)
        {
            Console.WriteLine("Let your work speak for you");
            var escuela = new Escuela("Meneses") {};
            // var cursos = new Curso() { Grado = "101" };
            // cursos = new Curso[3]
            Curso[] cursos = {
                new Curso() { Grado = "101", jornada = TipoJornada.tarde.ToString() },
                new Curso() { Grado = "201", jornada = TipoJornada.noche.ToString() }
            };

            WriteLine(escuela);
            foreach (Curso curso in cursos)
            {
                WriteLine("Curso: " + curso.Grado+" - ID: "+curso.uniqueID + " - Jornada: " + curso.jornada);
            }
            
        }
    }
}
