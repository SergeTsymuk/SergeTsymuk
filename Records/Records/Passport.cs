using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records
{
    public record Passport
    {
        public Passport(string firstName, string lastName) => (FirstName, LastName) = (firstName, lastName);
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
