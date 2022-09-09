using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_31_2022_2
{
    internal class Phone
    {
        private int number = 123456789;
        private string model = "Nokia 5610";
        private double weight = 56.25;

        //private int Number { get; set; }
        //private double Model { get; set; }
        //private double Weight { get; set; }

        public int Number 
        { 
            get { return number; }
            set { number = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Phone()
        {
           
        }

        public Phone(string model, int number)
        {
            Model = model;
            Number = number;
        }
        public Phone(string model, int number, double weight)
        {
            Weight=weight;
            Model = model;
            Number=number;
            var phone1 = new Phone(model, number);
        }

        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"Incomming Call From: {callerName}");
        }
        
        public void ReceiveCall(string callerName, int callerNumber)
        {
            Console.WriteLine($"Incomming Call From: {callerName}, number {callerNumber}");
        }

        public int GetNumber(int phoneNumber)
        {
            return phoneNumber;
        }
        
        public void SendMessage(params string[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" { numbers[i]} , ");
            }
            
        }
    }
}
