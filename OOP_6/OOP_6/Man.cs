using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Man
    {
        private string firstName = "First Name";
        private string lastName = "Last Name";

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public Man(string firstName, string lastName)
        {
           
        }

        public void PrintToConsole()
        {
            Console.WriteLine($" First Name: {FirstName}, \n Last Name: {LastName}");
        }

    }
}
