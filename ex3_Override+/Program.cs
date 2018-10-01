using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace F2Ex3f
{

    abstract class Quadrilatero
    {
        public double x { get; set; }
        public double y { get; set; }

        abstract public double Area();
        abstract public double Perimetro();
    }

    class Retangulo : Quadrilatero
    {
        public Retangulo() { }

        public Retangulo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override double Area() { return x * y; }
        public override double Perimetro() { return (2 * x + 2 * y); }
    }



    //class Quadrado : Retangulo
    //{
    //    // Caso 1: 
    //    public Quadrado() { }
    //    public Quadrado(double x) { this.x = x; }

    //    //public override double Area() { return x * x; }
    //    //public override double Perimetro() { return 4 * x; }

    //    public new double Area() { return x * x; }
    //    public new double Perimetro() { return 4 * x; }
    //}

    //class Quadrado : Retangulo
    //{
    //    //Caso 2:
    //    public Quadrado() : base() { }
    //    public Quadrado(double x) : base(x, 0) { }

    //    public override double Area() { return x * x; }
    //    public override double Perimetro() { return 4 * x; }
    //}

    class Quadrado : Retangulo
    {
        //Caso 3:
        public Quadrado() : base() { }
        public Quadrado(double x) : base(x, x) { }

        public override double Area() { return x * x; }
        public override double Perimetro() { return 4 * x; }
    }

    //class Quadrado : Retangulo
    //{
    //    //Caso 4:
    //    public Quadrado() : base() { }
    //    public Quadrado(double x) : base(x, 0) { }

    //    public override double Area() { return base.Area(); }
    //    public override double Perimetro() { return base.Perimetro(); }
    //}

    //class Quadrado : Retangulo
    //{
    //Caso 5:
    //public Quadrado() { this.y = 0; }
    //public Quadrado(double x) { this.x = x; }

    //public new double Area() { y = x; double area = base.Area(); y = 0; return area; }
    //public new double Perimetro() { y = x; double perimetro = base.Perimetro(); y = 0; return perimetro; }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            Retangulo rt = new Retangulo { x = 2, y = 1 };
            Retangulo rs = new Quadrado { x = 2, y = 1 };
            Quadrado sq = new Quadrado { x = 2, y = 1 };

            Console.WriteLine("\nRectangle: x= {0} y= {1}", rt.x, rt.y);
            Console.WriteLine("Rectangle[Square]: x= {0} y= {1}", rs.x, rs.y);
            Console.WriteLine("Square: x= {0} y= {1}\n", sq.x, sq.y);

            Console.WriteLine("\nArea: Rectangle= {0} Rectangle[square] = {1} and Square= {2}", rt.Area(), rs.Area(), sq.Area());
            Console.WriteLine("Perimetro: Rectangle= {0} Rectangle[square] = {1} and Square= {2}", rt.Perimetro(), rs.Perimetro(), sq.Perimetro());

            Retangulo rt2 = new Retangulo(2, 1);
            Retangulo rs2 = new Quadrado(2);
            Quadrado sq2 = new Quadrado(2);

            Console.WriteLine("\nRectangle: x= {0} y= {1}", rt2.x, rt2.y);
            Console.WriteLine("Rectangle[Square]: x= {0} y= {1}", rs2.x, rs2.y);
            Console.WriteLine("Square: x= {0} y= {1}\n", sq2.x, sq2.y);

            Console.WriteLine("\nArea: Rectangle= {0} Rectangle[square] = {1} and Square= {2}", rt2.Area(), rs2.Area(), sq2.Area());
            Console.WriteLine("Perimetro: Rectangle= {0} Rectangle[square] = {1} and Square= {2}", rt2.Perimetro(), rs2.Perimetro(), sq2.Perimetro());


            return;
        }
    }
}



