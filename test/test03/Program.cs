using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test03
{

    public class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
            Console.Write("{");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int y = 0; y < mas.GetLength(2); y++)
                    {
                        Console.Write(mas[i, j, y]);
                        if (y != mas.GetLength(2) -1)
                        {
                            Console.Write(",");
                        }
                    }
                    Console.Write("}");
                    if (j != mas.GetLength(2) - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("}");
            }
            Console.Write("}");
            Console.ReadKey();

        }

        
    }
}

