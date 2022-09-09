using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate
{
    internal class Notifier
    {
        

        public delegate void MessageHandler(string message);
        public MessageHandler Message;

        public void DoSomething()
        {
            Message("text");
            Message?.Invoke("Do Something");
        }
    }
}
