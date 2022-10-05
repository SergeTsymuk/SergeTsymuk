using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2022
{
    internal class NewsProvider
    {
        public void BasicNewsReader(string news, string weather)
        {
            Console.WriteLine(news);
            Console.WriteLine(new string('.', 30));
            Console.WriteLine(weather);
            Console.WriteLine(new string('.', 30));
        }

        public void StandardNewsReader(string news, string weather, string incidents)
        {
            Console.WriteLine(news);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(weather);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(incidents);
            Console.WriteLine(new string('-', 30));
        }

        public void PremiumNewsReader(string news, string weather, string incidents, string humor, string sport)
        {
            Console.WriteLine(news);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(weather);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(incidents);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(humor);
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(sport);
            Console.WriteLine(new string('*', 30));
        }

    }
}
