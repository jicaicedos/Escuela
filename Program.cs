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
                new Curso() { Grado = "101"},
                new Curso() { Grado = "201"},
                new Curso() { Grado = "301"},
                new Curso() { Grado = "401"},
                new Curso() { Grado = "501"},
                new Curso() { Grado = "601"}
            };

            WriteLine(escuela);
            foreach (Curso curso in cursos)
            {
                WriteLine(curso.Grado);
            }
            
        }
    }
}
