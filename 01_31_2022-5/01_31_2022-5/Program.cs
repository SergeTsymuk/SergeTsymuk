using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number of lines for Array1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter number of Columns for Array1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter number of lines for Array2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter number of Columns for Array2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the number to multyply an arrey");
            int number = Convert.ToInt32(Console.ReadLine());
            
            double[,] array1 = new double[x1,y1];
            double[,] array2 = new double[x2,y2];

            Random random = new Random();
            //creating our Array1
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = random.Next(100);
                }
            }
            //creating our Array2
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = random.Next(100);
                }
            }

            Array array = new Array();

            Console.WriteLine(array.SumOfArrays(array1, array2));
            Console.WriteLine(array.MultiplicationToNumber(array1, number));

            Console.ReadLine();
        }
    }
}
