namespace pooPolimorfismo
{
    public class Triangulo : Formas
    {
        public Triangulo() : base()
        {
            base.FormaGeometrica = "Triangulo";
        }

        public Triangulo(double Base, double Altura) : base("Triangulo", Base, Altura)
        {
        }
        public override string FormaGeometrica { get => base.FormaGeometrica; }
        public override double CalcularArea()
        {
            return (this.Base * this.Altura) / 2;
        }
    }
}
