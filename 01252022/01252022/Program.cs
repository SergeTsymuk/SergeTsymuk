using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01252022
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //Animal abstractAnimal = new Animal();
            //Cat concreteCat = (Cat)abstractAnimal;






            Animal dog = new Dog(), cat = new Cat();
            Animal[] animals = { dog, cat };

            for (int i = 0; i < animals.Length; i++)
            {
                Animal animal = animals[i];

                if (animal is Dog isDog)
                {
                    isDog.BringStick();
                }
                else if (animal is Cat isCat)
                {
                    isCat.CatchMouse();
                }
                else
                {
                    ; // Do Nothing
                }
            }










            /*for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
            
            Animal animal = animals[0];
            Animal animal2 = animals[1];
            //bool dogIsDog = animal is Dog;
            //Dog myDog = (dogIsDog == true) ? (Dog)animal : null;
            Dog myDog = animal as Dog;
            
            //if (myDog != null)
            
            myDog?.BringStick();
            //Cat myCat = (animal is Cat) ? (Cat)animal : null;

            //if (myCat != null)
            Cat myCat = animal2 as Cat;
            
            //if(myCat != null)
            
            myCat?.CatchMouse();

            //Dog myDog = (Dog)animal;
            //myDog.BringStick();

            //Cat myCat = (Cat)animal;
            //myCat.CatchMouse();*/


            Console.ReadLine();
        }
    }
}
