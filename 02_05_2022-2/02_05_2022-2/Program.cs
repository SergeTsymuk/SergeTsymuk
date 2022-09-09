using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_05_2022_2
{
    class Bird { public virtual void Fly(string name) => Console.WriteLine($"{name}: Fly "); }

    class Canary : Bird { }

    class Ostrich : Bird { public override void Fly(string name) => Console.WriteLine($"{name}: Not flying"); }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("_02_05_2022_2.Dog");
            Animal dog = Activator.CreateInstance(type) as Animal;
            dog?.Run(new Dog());
            Console.ReadKey();

            Taksa x = new Taksa();
            x.ShowSize();
            StandardTaksa y = new StandardTaksa();
            y.ShowSize();
            Console.ReadKey();

            //Canary canary = new Canary();
            //canary.Fly(nameof(canary));
            //Ostrich ostrich = new Ostrich();
            //ostrich.Fly(nameof(ostrich));
            
            //Bird bird = new Canary();
            //bird.Fly(nameof(Canary));
            //bird = new Ostrich();
            //bird.Fly(nameof(Ostrich));

            Bird[] birds = { new Canary(), new Ostrich() };

            for (int i = 0; i < birds.Length; i++)
                birds[i].Fly(birds[i].ToString());
            
            MyClass.DisplayVariable();
            MyClass.Property = "Privet!";
            MyClass.DisplayVariable();

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int randomNumber = random.Next(2);
                Animal animal;
                if (randomNumber == 0)
                    animal = new Dog();
                else
                animal = new Cat();
                animal.Run(animal);
                animal.MakeSound();
            }

            Console.ReadKey();
        }
    }
}
