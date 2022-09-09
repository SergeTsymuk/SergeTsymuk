using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022_5
{
    internal class Array
    {
        private int rowNumber = 0;
        private int columnNumer = 0;
        double[,] sumArray = null;


        public int RowNumber { get { return rowNumber; } set { rowNumber = value; } }
        public int ColumnNumer { get { return columnNumer; } set { columnNumer = value; } }

        public double[,] SumOfArrays(double[,] array1, double[,] array2)
        {
            if (array1.GetLength(0) == array2.GetLength(0) && array1.GetLength(1) == array2.GetLength(1))
            {
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        sumArray[i, j] = array1[i, j] + array2[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("Couldn't be done! Arrays have different sizes!");
            }
            return sumArray;
        }

        public double[,] MultiplicationToNumber(double[,] array1, double number)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    sumArray[i, j] = array1[i, j] * number;
                }
            }
            return sumArray;
        }

        public void Print(double[,] array1, double number)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(sumArray[i, j]);
                }
            }
        }

        public double[,] MultiplicationOfArrays(double[,] array1, double[,] array2)
        {
            if (array1.GetLength(0) == array2.GetLength(1)) // check for multiplication term
            {
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        for (int k = 0; k < array1.GetLength(0); k++)
                        {
                            sumArray[i, j] += array1[i, k] * array2[k, j];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Couldn't be done! Arrays have different sizes!");
            }
            return sumArray;
        }
    }
}
