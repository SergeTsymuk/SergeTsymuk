using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone() { Model = "NOKIA 6110", Number = 245672521, Weight = 25.36};
            Phone phone2 = new Phone() { Model = "SAMSUNG", Number = 12456872, Weight = 51.35};
            Phone phone3 = new Phone() { Model = "Apple", Number = 24521154, Weight = 24.21};

            Console.WriteLine($"Model is: {phone1.Number}, Number is: {phone1.Model}, Weight is: {phone1.Weight}");
            Console.WriteLine($"Model is: {phone2.Number}, Number is: {phone2.Model}, Weight is: {phone2.Weight}");
            Console.WriteLine($"Model is: {phone3.Number}, Number is: {phone3.Model}, Weight is: {phone3.Weight}");

            phone1.ReceiveCall("Ivanov", 26541225);

            string[] callingNumbers =
                {
                    "+ 375 294 95 65 84", "+ 375 294 95 64 84", "+ 375 294 95 63 84", "+ 375 294 95 65 75", "+ 375 294 95 65 94",
                    "+ 375 294 95 65 67", "+ 375 294 48 64 84", "+ 375 294 34 63 84", "+ 375 294 95 65 92", "+ 375 294 17 65 94",
                    "+ 375 294 95 44 84", "+ 375 294 12 64 84", "+ 375 294 95 63 75", "+ 375 294 95 65 16", "+ 375 294 95 65 34",
                    "+ 375 294 18 65 84", "+ 375 294 95 64 84", "+ 375 294 95 63 72", "+ 375 294 95 25 75", "+ 375 294 27 65 94",
                    "+ 375 294 95 65 16", "+ 375 294 95 64 75", "+ 375 294 95 63 14", "+ 375 294 95 65 67", "+ 375 294 95 65 98",
                    "+ 375 294 95 15 84", "+ 375 294 95 12 84", "+ 375 294 95 17 84", "+ 375 294 95 35 75", "+ 375 294 95 34 94"
                };

            phone1.SendMessage(callingNumbers);

            Console.ReadLine();
        }
    }
}
