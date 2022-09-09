using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2022
{
    public class Helper
    {
        public void ShowArrayList(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('*', 25));
        }

        public void ShowList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 25));
        }
    }
}
