using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Rectangulo : Forma
    {
        public double Comprimento { get; set };
        public double Largura { get; set };

        public Rectangulo()
        {
            Comprimento = 0;
            Largura = 0;
        }

        public Rectangulo(double comp, double lar)
        {
            Comprimento = comp;
            Largura = lar;
        }



        public override double Area()
        {
            return Comprimento * Largura;
        }
        public override double Perimetro()
        {
            return (2 * Comprimento) + (2 * Largura);

        }
        public override string Detalhe(string formato)
        {

        }
    }
}
