using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022
{
    internal class Person
    {
        private string fullName;
        private int age;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person()
        {
            FullName = "N/A";
            Age = 0;
        }

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        public void Move()
        {
            Console.WriteLine($"{FullName}, age: {Age} is walking");
        }

        public void Talk()
        {
            Console.WriteLine($"{FullName}, age: {Age} is talking");
        }
    }
}
