using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPhone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();
            
            phone1.ReceiveCall("Viktor");
            phone1.GetNumber();
            phone2.ReceiveCall("Sergey");
            phone2.GetNumber();
            phone3.ReceiveCall("Alex");
            phone3.GetNumber();

            phone1.ReceiveCall("Viktor", 25648214);
            phone1.ReceiveCall("Sergey", 25648214);
            phone1.ReceiveCall("Alex", 25648214);

            Console.WriteLine($"Model: {phone1.model}, Number: {phone1.number}, Weight: {phone1.weight}");
            Console.WriteLine($"Model: {phone2.model}, Number: {phone2.number}, Weight: {phone2.weight}");
            Console.WriteLine($"Model: {phone3.model}, Number: {phone3.number}, Weight: {phone3.weight}");
            Console.Read();
            D d4 = (D)d1;
        }
    }
}
