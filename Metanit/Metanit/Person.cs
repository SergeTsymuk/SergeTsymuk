using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit
{
    public class Person
    {
        public Person(string name, int age, string city, bool isEmployee)
        {
            Name = name;
            Age = age;
            City = city;
            IsEmployee = isEmployee;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public bool IsEmployee { get; set; }
    }
}
