using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [,,] shelfs = new string[5,10,10];
            // setting up values for 3 random elements of array
            shelfs.SetValue("Book1", 4, 6, 3);
            shelfs.SetValue("Book2", 2, 6, 1);
            shelfs.SetValue("Book3", 0, 2, 2);
            Console.WriteLine("Please Enter the name of the Book: Book1, Book2, Book3");
            string seekingBook = Console.ReadLine();
            for (int x = 0; x < shelfs.GetLength(0); x++)
            {
                for (int y = 0; y < shelfs.GetLength(1); y++)
                {
                    for (int z = 0; z < shelfs.GetLength(2); z++)
                    {
                        string bookName = shelfs[x, y, z];
                        if (bookName == seekingBook)
                        {
                            Console.WriteLine($"Your book lokation:  Stand # {x + 1}, Shelf # {y+1}, Place # {z + 1};");
                        }
                    }

                }
            }
            Console.ReadLine();

        }
    }
}
