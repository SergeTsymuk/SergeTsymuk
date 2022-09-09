using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_11_2022
{
    internal class Footer
    {
        //decimal total = 0;
        string storekeeperSurname = null;
        string forwarderSurname = null;

        //public decimal Total { get { return total; } set { total = value; } }
        public string StorekeeperSurname { get { return storekeeperSurname; } set { storekeeperSurname = value; } }
        public string ForwarderSurname { get { return forwarderSurname; } set { forwarderSurname = value; } }
    }
}
