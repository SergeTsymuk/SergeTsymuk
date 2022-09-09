using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_35_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter number of Lines for Array #1");
            int linesNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter number of Columns for Array #1");
            int columnsNumber = Convert.ToInt32(Console.ReadLine());
            int[,] firstArray = new int[linesNumber, columnsNumber];
            Console.WriteLine();
            for (int i = 0; i < linesNumber; i++)
            {
                    for (int j = 0; j < columnsNumber; j++)
                    {
                    Console.WriteLine($"Please Enter 'Line': {i} 'Column':{j} to fill up an Array #1");
                    firstArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nFirst Array:");
            int height = firstArray.GetLength(0);
            int width = firstArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"Y{y},X{x}, {firstArray[y, x]}  \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nPlease Enter number of Lines for Array #2");
            int linesNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter number of Columns for Array #2");
            int columnsNumber2 = Convert.ToInt32(Console.ReadLine());
            int[,] secondArray = new int[linesNumber2, columnsNumber2];
            Console.WriteLine();
            for (int i = 0; i < linesNumber2; i++)
            {
                for (int j = 0; j < columnsNumber2; j++)
                {
                    Console.WriteLine($"Please Enter 'Line': {i} 'Column':{j} to fill up an Array #2");
                    secondArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nSecond Array:");
            int height2 = secondArray.GetLength(0);
            int width2 = secondArray.GetLength(1);

            for (int y = 0; y < height2; y++)
            {
                for (int x = 0; x < width2; x++)
                {
                    Console.Write($"Y{y} ,X {x}, {secondArray[y, x]}  \t");
                }

                Console.WriteLine();
            }

            int[,] resultArray = new int[columnsNumber, linesNumber2];
            if (linesNumber == columnsNumber2)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width2; j++)
                    {
                        for (int k = 0; k < secondArray.GetLength(0); k++)
                        {
                            resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                        }
                    }
                }
                Console.WriteLine("\nMultiplied Array: ");
                int height3 = resultArray.GetLength(0);
                int width3 = resultArray.GetLength(1);
                for (int y = 0; y < height3; y++)
                {
                    for (int x = 0; x < width3; x++)
                    {
                        Console.Write(resultArray[y, x] + "\t");
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nMultiplication rules NOT met!");
            }
            Console.ReadLine();
        }
    }
}
