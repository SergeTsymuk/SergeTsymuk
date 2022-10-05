using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2022
{

    internal class Client
    {
        private string firstName;
        private string lastName;
        private int subscription;

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Client(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
