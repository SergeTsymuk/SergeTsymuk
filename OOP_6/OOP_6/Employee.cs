using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Employee : Worker
    {
        private string company = "Company Name";
        private double salary = 98456.90;
        
        public string Company { get { return company; } set { company = value; } }
        public double Salary { get { return salary; } set { salary = value; } }

        public Employee(string firstName, string lastName, string occupation, int phone, string company, double salary)
            : base(firstName, lastName, occupation, phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Occupation = occupation;
            Phone = phone;
        }

        public new void PrintToConsole()
        {
            Console.WriteLine($" First Name: {FirstName}, \n Last Name: {LastName}, \n Occupation: {Occupation}, " +
                                $"\n Phone #: {Phone}, \n Company: {Company}, \n Salary: {Salary}");
        }

    }
}
