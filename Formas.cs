namespace pooPolimorfismo
{
    public class Formas
    {
        public Formas()
        {
            this.FormaGeometrica = "";
            this.Base = 0;
            this.Altura = 0;
        }
        public Formas(string Forma, double Base, double Altura)
        {
            this.FormaGeometrica = Forma;
            this.Base = Base;
            this.Altura = Altura;
        }
        public virtual string FormaGeometrica { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }
        public virtual double CalcularArea()
        {
            return 0;
        }
    }
}
