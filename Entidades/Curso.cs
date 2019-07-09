namespace Principal.Entidades
{
    public class Curso
    {
        public string Grado { get; set; }

        public override string ToString() {
            return $"Grado: {Grado}";
        }
    }    
}