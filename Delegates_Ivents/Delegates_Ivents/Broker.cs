using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Ivents
{
    internal class Broker : IObserver
    {
        public string Name { get; set; }
        IObservable stock;
        public Broker(string name, IObservable obs)
        {
            this.Name = name;
            stock = obs;
            stock.AddObserver(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 30)
                Console.WriteLine("Broker {0} selling USD;  USD exchange rate: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Broker {0} buying USD;  USD exchange rate: {1}", this.Name, sInfo.USD);
        }
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
