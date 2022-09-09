using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPhone
{
    public class Phone
    {
        public int number;
        public string model;
        public double weight;

        public Phone()
        {

        }

        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(int number, string model, double weight)
            : this(number, model)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }

        public void ReceiveCall(string nameOfCaller)
        {
            Console.WriteLine($"Incomming Call From: {nameOfCaller}");
        }

        public void ReceiveCall(string nameOfCaller, int numberOfCaller)
        {
            Console.WriteLine($"Incomming Call From: {nameOfCaller}, # {numberOfCaller}");
        }


        public int GetNumber()
        {
            return number;
        }

    }
}
