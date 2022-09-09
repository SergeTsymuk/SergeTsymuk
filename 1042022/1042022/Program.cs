using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter First number: ");
            int coordinatX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese enter Second number: ");
            int coordinatY = Convert.ToInt32(Console.ReadLine());

            string answer = ( coordinatX> 0 && coordinatY > 0) ? ("quarter 1") : 
                (coordinatX > 0 && coordinatY < 0) ? ("quarter 4") : 
                (coordinatX < 0 && coordinatY < 0) ? ("quarter 3") : "quarter 2";

            Console.WriteLine(answer);
            Console.ReadLine();
                


        }
    }
}
