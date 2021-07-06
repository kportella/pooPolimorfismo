namespace pooPolimorfismo
{
    public class Quadrado : Formas
    {
        public Quadrado() : base()
        {
            base.FormaGeometrica = "Quadrado";
        }

        public Quadrado(double Base, double Altura) : base("Quadrado", Base, Altura)
        {
        }
        public override string FormaGeometrica
        {
            get => base.FormaGeometrica;
        }

        public string Teste { get; set; }


        public override double CalcularArea()
        {
            return this.Base * this.Base;
        }
    }
}
