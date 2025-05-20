using System;

class Program
{
    static void Main(string[] args)
    {
        IFigura retangulo = new Retangulo(10, 20);
        Console.WriteLine($"Área do retângulo: {retangulo.CalcularArea()}");

        IFigura triangulo = new Triangulo(10, 20);
        Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
    }
}

// Interface para padronizar formas geométricas
interface IFigura
{
    double CalcularArea();
}

// Classe Retângulo implementando a interface
class Retangulo : IFigura
{
    public double Largura { get; }
    public double Altura { get; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }
}

// Classe Triângulo implementando a interface
class Triangulo : IFigura
{
    public double Base { get; }
    public double Altura { get; }

    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return (Base * Altura) / 2; 
    }
}
