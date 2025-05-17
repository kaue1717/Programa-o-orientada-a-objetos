usisng System;

public class Animal
{
    public void FazerSom()
    {
        Console.WriteLine("Som de animal");
    }
}

class Program
{
    static void Main()

    Animal animal = new Animal();
    Animal.FazerSom();

}
//Pode ser instanciado

using System;

public abstract class Animal
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("Au Au");
        }
    }
}

class Program
{
    static void Main(
        {
        Animal meucachorro = new Cachorro();
        {
            meucachorro.FazerSom();
        }
    }
    )
}

// n pode ser instanciado. Perceba que aqui , eu teno que pegar e criar
// uma classe do cachorro que herda de animal
// e implementar o método FazerSom