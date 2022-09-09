using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            decimal tax = 20;
            double pricePerMin = 2;
            Console.WriteLine("Please enter time used in 1-st Month");
            double firstMonth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter time used in 2-nd Month");
            double secondMonth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter time used in 3-rd Month");
            double thirdMonth = Convert.ToDouble(Console.ReadLine());
            double summOfMinQuarter = (firstMonth + secondMonth + thirdMonth);
            double sumAccordingToPriceList = (summOfMinQuarter * pricePerMin);
            double sumOfTax = (summOfMinQuarter / 100 * Convert.ToDouble(tax));

            Console.WriteLine("Total minutes used: " + " " + summOfMinQuarter);
            Console.WriteLine("Tax: " + sumOfTax);
            Console.WriteLine("Total Ammount: " + sumAccordingToPriceList + sumOfTax);
            Console.ReadLine();
            
        }
    }
}
