using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"{numbers[j]} ");
            }
            Console.WriteLine(new String('*', 25));
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
