using System;
using System.Collections.Generic;

namespace pooPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado(2, 2);
            Quadrado q2 = new Quadrado(4, 4);
            Quadrado q3 = new Quadrado(8, 8);

            Triangulo t1 = new Triangulo(2, 2);
            Triangulo t2 = new Triangulo(4, 4);
            Triangulo t3 = new Triangulo(8, 8);

            List<Formas> Formas = new List<Formas>();
            Formas.Add(q1);
            Formas.Add(q2);
            Formas.Add(q3);
            Formas.Add(t1);
            Formas.Add(t2);
            Formas.Add(t3);

            // foreach (var item in Formas)
            // {
            //     Console.WriteLine("Tipo da forma: " + item.FormaGeometrica);
            //     Console.WriteLine("Base: " + item.Base);
            //     Console.WriteLine("Altura: " + item.Altura);
            //     Console.WriteLine("Calculo da area: " + item.CalcularArea());
            // }

            exibirTipo(q1);
            Console.ReadKey();
        }

        static void exibirTipo(Formas forma)
        {
            Quadrado q = (Quadrado)forma;
            q.Teste = "dsSADsasd";
            Console.WriteLine("Tipo da forma: " + forma.FormaGeometrica);
        }
    }
}
