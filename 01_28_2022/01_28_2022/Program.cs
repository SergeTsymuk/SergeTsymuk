using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyArray1[0] = 22;
            instance.MyArray2[0] = 33;
            Console.WriteLine($"array1[0] = {instance.MyArray1[0]}, " +
                                $"aray2[0] = {instance.MyArray2[0]}");

            instance[0, 0] = 777;
            Console.WriteLine(instance[0, 0]);



            for (int i = 0; i < instance.GetLenght(0); i++)
            {
                for (int j = 0; j < instance.GetLenght(1); j++)
                {
                    Console.WriteLine(instance[i, j]);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
