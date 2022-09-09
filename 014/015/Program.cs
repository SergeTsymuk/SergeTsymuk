using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Quantity Of The Product: ");
            double quantityOfProduct = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Price for 1m");
            double price = Convert.ToDouble(Console.ReadLine());

            double totalPrice = (quantityOfProduct * price);
            double sumOfDiscount = (totalPrice * 0.1); //discount is 10%
            double totalWithDiscountApplied = (totalPrice - sumOfDiscount);
            Console.WriteLine(" Total Ammount: " + totalPrice + 
                "\n Summ of Discount: " + sumOfDiscount + "\n Total: " + totalWithDiscountApplied);
            Console.ReadLine();
        }
    }
}
