using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract partial class Forma
{
    public abstract double Area();
    public abstract double Perimetro();
    public abstract void Detalhe(string formato);
}


//*********************************
//CLASSE RETANGULO

partial class Retangulo : Forma
{
    public double comprimento { get; set; }
    public double largura { get; set; }


    public Retangulo(double comp = 0, double larg = 0)
    {
        comprimento = comp;
        largura = larg;
    }

    public override double Area()
    {
        return comprimento * largura;
    }

    public override double Perimetro()
    {
        return 2 * comprimento + 2 * largura;
    }

    public override void Detalhe(string formato)
    {
        Console.WriteLine("\n{0}: Comrimento= {1} Largura= {2}", GetType(), comprimento.ToString(formato), largura.ToString(formato));
        Console.WriteLine("Area= {0} Perimetro= {1}", Area().ToString(formato), Perimetro().ToString(formato));
    }
}

//*********************************
//CLASSE TRIANGULO

partial class Triangulo : Forma
{
    public double Plado { get; set; }
    public double Slado { get; set; }
    public double Tlado { get; set; }

    public Triangulo(double Plado, double Slado, double Tlado)
    {
        this.Plado = Plado; this.Slado = Slado; this.Tlado = Tlado;
    }

    public override double Area()
    {
        double sp = Perimetro() / 2;
        return Math.Sqrt(sp * (sp - Plado) * (sp - Slado) * (sp - Tlado));
    }

    public override double Perimetro()
    {
        return Plado + Slado + Tlado;
    }

    public override void Detalhe(string formato)
    {
        Console.WriteLine("\n{0}: Lados= {1} | {2} | {3}", GetType(), Plado.ToString(formato), Slado.ToString(formato), Tlado.ToString(formato));
        Console.WriteLine("Area= {0} Perimetro= {1}", Area().ToString(formato), Perimetro().ToString(formato));
    }
}


//*********************************
//CLASSE CIRCULO

partial class Circulo : Forma
{
    public double raio { get; set; }

    public Circulo(double r = 0)
    {
        raio = r;
    }

    public override double Area()
    {
        return Math.Pow(raio, 2) * Math.PI;
    }


    public override double Perimetro()
    {
        return 2 * Math.PI * raio;
    }

    public override void Detalhe(string formato)
    {
        Console.WriteLine("\n{0}: Raio= {1}", GetType(), raio.ToString(formato));
        Console.WriteLine("Area= {0} Perimetro= {1}", Area().ToString(formato), Perimetro().ToString(formato));
    }

}

//*********************************
//MAIN

class Program
{
    static void Main()
    {
        //Mock data 1
        Retangulo r1 = new Retangulo(5, 6);
        r1.Detalhe("F1");

        Forma r2 = new Retangulo(5, 6);
        r2.Detalhe("F1");


        Triangulo t1 = new Triangulo(3, 4, 5);
        t1.Detalhe("F2");

        Forma t2 = new Triangulo(3, 4, 5);
        t2.Detalhe("F2");


        Circulo c1 = new Circulo() { raio = 7.5 };
        c1.Detalhe("F3");

        Forma c2 = new Circulo() { raio = 7.5 };
        c2.Detalhe("F3");

        Console.WriteLine();
    }

}


