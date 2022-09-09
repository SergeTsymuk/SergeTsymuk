using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Worker : Man
    {
        private int phone = 1234567890;
        private string occupation = "Ocupation";
        
        public int Phone { get { return phone; } set { phone = value; } }
        public string Occupation { get { return occupation; } set { occupation = value; } }

        public Worker(string firstName, string lastName, string occupation, int phone)
            : base(firstName, lastName)
        {
           FirstName = firstName;
           LastName = lastName;
        }

        public new void PrintToConsole()
        {
            Console.WriteLine($" First Name: {FirstName}, \n Last Name: {LastName}, \n Occupation: {Occupation}, " +
                                $"\n Phone #: {Phone}");
        }



    }
}
