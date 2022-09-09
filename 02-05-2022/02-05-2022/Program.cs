// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using _02_05_2022;


static void Main(string[] args)
{
    Type type = Type.GetType("_02_05_2022");
    Animal dog = Activator.CreateInstance(type) as Animal;
    dog?.Run(new Dog());
    Console.ReadKey();

    //MyClass.DisplayVariable();
    //MyClass.Property = "Privet Mir";
    //MyClass.DisplayVariable();

    //Taksa x = new Taksa();
    //x.ShowSize();
    //StandardTaksa y = new StandardTaksa();
    //y.ShowSize();

    //Canary canary = new Canary();
    //canary.Fly(nameof(canary));
    //Ostrich ostrich = new Ostrich();
    //ostrich.Fly(nameof(canary));
    Random random = new();

    for (int i = 0; i < 5; i++)
    {
        int randomNumber = random.Next(2);
        Animal animal;
        if (randomNumber == 0)
        {
            animal = new Dog();
        }
        else
        {
            animal = new Cat();
        }
        animal.Run(animal);
        animal.MakeSound();
        Console.ReadLine();
    }
}
    
