// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Bird { public virtual void Fly(string name) => Console.WriteLine($"{name}: Fly "); }

class Canary : Bird { }

class Ostrich : Bird { public void Fly(string name) => Console.WriteLine($"{name}: Not flying"); }

internal class Program
{
    static void Main(string[] args)
    {
        //Type type = Type.GetType("_02_05_2022_2.Dog");
        //Animal dog = Activator.CreateInstance(type) as Animal;
        //dog?.Run(new Dog());
        //Console.ReadKey();

        //MyClass.DisplayVariable();
        //MyClass.Property = "Privet Mir";
        //MyClass.DisplayVariable();

        //Taksa x = new Taksa();
        //x.ShowSize();
        //StandardTaksa y = new StandardTaksa();
        //y.ShowSize();

        Canary canary = new Canary();
        canary.Fly(nameof(canary));
        Ostrich ostrich = new Ostrich();
        ostrich.Fly(nameof(canary));
    }
}
