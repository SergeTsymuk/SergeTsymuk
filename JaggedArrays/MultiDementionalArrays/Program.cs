using System;

namespace MultiDementionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------2 demention array---------
            Console.WriteLine("\n2 demantion Array \n");
            byte[,] arr2 = new byte[3, 2] { { 4, 6 }, { 2, 6 }, { 8, 6 } };

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    //int element = array[i, j];
                    Console.Write($"{arr2[i, j]} ");
                }
                Console.WriteLine();
            }
            //-------------3 demention array---------
            Console.WriteLine("\n3demention Array \n");
            byte[,,] array3 = new byte[3, 2, 3]
            {
                {
                    {4, 6, 5 },
                    {2, 6, 8 },
                },
                {
                    { 4, 6, 7 },
                    { 2, 6, 6 },
                },
                {
                    { 4, 6, 4 },
                    { 2, 6, 9 },
                }
            };

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    for (int k = 0; k < array3.GetLength(2); k++)
                    {
                        Console.Write($"{array3[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


        }
    }
}
