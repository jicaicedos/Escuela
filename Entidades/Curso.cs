using System;

namespace Principal.Entidades
{
    public class Curso
    {
        public string Grado { get; set; }

        public string uniqueID { get; private set; }

        public string jornada { get; set; }

        public Curso() => uniqueID = Guid.NewGuid().ToString();
    }    
}