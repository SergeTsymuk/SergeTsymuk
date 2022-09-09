using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_11_2022
{
    internal class Invoice
    {
        public Title Title {get;set;} = new Title();
        public Body Body {get;set;} = new Body();
        public Footer Footer {get;set;} = new Footer();
        //public Goods Goods { get;set;} = new Goods();
        

        //    Console.WriteLine($"\n Number {body.SequanceNumber} || \t Name Of the Product: {body.ProductName} || \t Quantity: {body.Quantity} ||" +
        //                    $"\t Price: {body.Price} || \t Summ of the Price: {body.SumPrice} ");
            
        //    Console.WriteLine($"\n TOTAL SUMM: {footer.Total} || \n Store Keeper Name: {footer.StorekeeperSurname} || " +
        //                            $"\t Forwarder Name: {footer.ForwarderSurname}");
        //}
        public void PrintInvoice()
        {
            Console.WriteLine($"\n\n- - - - - - - - - - - - - - - - - - - - -    INVOICE    - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"Date: {Title.Date}");
            Console.WriteLine($"INVOICE #: {Title.Number}");
            Console.WriteLine($"To: {Title.To}");
            Console.WriteLine($"From: {Title.From}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -    Product info     - - - - - - - - - - - - - - - - - - -");

            for (int index = 0; index < Body.Goods.Length; index++)
            {
                Goods goods = Body.Goods[index];
                Console.WriteLine($"{index + 1}). {goods.ProductName}, \t|| {goods.Quantity} \t|| {goods.Price * goods.Quantity}");
            }
            foreach (Goods item in Body.Goods)
            {
                Console.WriteLine($"{item.ProductName}");
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -    Other info     - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"Store Keeper: {Footer.StorekeeperSurname} ");
            Console.WriteLine($"Forwarder: {Footer.ForwarderSurname}");
            Console.WriteLine($"\n -------------------------------------   END OF INVOICE   --------------------------------------\n\n");
        }
    }
}
