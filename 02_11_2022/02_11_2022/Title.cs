using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_11_2022
{
    internal class Title
    {
        public DateTime date = DateTime.Now;
        string number = null;
        string to = null;
        string from = null;

        public string Number { get { return number; } set { number = value; } }
        public string To { get { return to; } set { to = value; } }
        public string From { get { return from; } set { from = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}
