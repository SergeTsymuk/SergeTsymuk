using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{
    public   class Phone
    {
        private int phoneNumber = 215932687;
        private string phoneModel = "Nokia";
        private double phoneWeight = 3.59;

        public int PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string PhoneModel { get { return phoneModel; } set { phoneModel = value; } }
        public double PhoneWeight { get { return phoneWeight; } set { phoneWeight = value; } }

        public Phone()
        {

        }
        public Phone(int number, string model)
        {
            PhoneNumber = number;
            PhoneModel = model;
        }
        public Phone(double weight, string model, int number) : this(number, model)
        {
            PhoneWeight = weight;
        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"{callerName} is Calling");
        }
        public void ReceiveCall(string callerName, int callerNumber)
        {
            Console.WriteLine($"{callerName} is Calling from {callerNumber}");
        }
        public int GetNumber(int callerNumber)
        {
            Console.WriteLine($"Incomming number {callerNumber}");
            return callerNumber;
        }

    }
}
