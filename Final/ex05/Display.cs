using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
    internal class Display
    {
        //private int seatAval;
        //private int customers = 0;
        public int seatLeft = 0;
        
        public int SeatAval { get; set; }
        public int Customers { get; set; }
        public int SeatLeft { get; set; }

        public void DisplayMenu(ref int tablesAval)
        {
            SeatAval = tablesAval;
            SeatLeft = SeatAval - Customers;
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to 'The Caffee'!");
            Console.WriteLine($"\n\nAvailable Tables in 'The Caffee': {SeatAval}");
            Console.WriteLine($"Number of vacant tables 'The Caffee': {SeatLeft}");
            Console.WriteLine($"Number of Customers in 'The Caffee': {Customers}");
            Console.WriteLine("\nPress: '1' to Add to customers.");
            Console.WriteLine("Press: '2' to Delete customers");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1 || userInput == 2)
            {
                switch (userInput)
                {
                    case 1:
                        this.Add();
                        break;

                    case 2:
                        this.Delite();
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong ENTRY! Please try again");
                Console.WriteLine("\nPress: '1' to Add customers.");
                Console.WriteLine("Press: '2' to Delete customers.");
            }
            
        }

        public void Add()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to 'The Caffee'!");
            Console.WriteLine($"\nPlease Enter number of customers coming in up to {SeatAval}!");
            int customersIn = Convert.ToInt32(Console.ReadLine());
            if (customersIn > 0 && customersIn <= SeatAval)
            {
                Customers = customersIn;
                SeatLeft = SeatAval - Customers;
            }
            else
            {
            this.Add();
            }
        }

        public void Delite()
        {
            
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome to 'The Caffee'!");
            Console.WriteLine($"\nPlease Enter number of customers leaving 'The Caffee' from 1 to {Customers}!");
            int costomerOut = Convert.ToInt32(Console.ReadLine());
            //Customers 
            //if (Customers == 0)
            //{
            //    Console.Clear();
            //    Console.WriteLine("\t\t\tHello! Welcome to 'The Caffee'!");
            //    Console.WriteLine($"\nNo customers left in 'The Caffee'!");
            //    this.DisplayMenu(ref seatAval);
            //}
            int seatCheck = SeatAval - SeatLeft;
            if(Customers > 0 && seatCheck >= costomerOut)
            {
                SeatLeft += costomerOut;
                Customers -= costomerOut;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\t\t\tHello! Welcome to 'The Caffee'!");
                Console.WriteLine($"\nPlease Enter number of customers leavin 'The Caffee' from 1 to {Customers}!");
                this.Delite();
            }
        }

    }
    
}
