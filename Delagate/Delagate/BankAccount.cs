using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagate
{
    internal class BankAccount
    {
        public delegate void NotifierHandler(string mes);
        public event NotifierHandler Notify;
        private decimal Cash;

        public void Add(decimal cash)
        {
            Cash = Cash + cash;
            Notify?.Invoke($"Funds was added: {cash}");
            Notify?.Invoke($"Available funds: {cash}");
        }
        public void Withdrawal(decimal cash)
        {
            if (Cash < cash)
            {
                Notify?.Invoke("Insufficient funds");
                return;
            }
            Cash = Cash - cash;
            Notify?.Invoke($"Funds after withdrawal: {cash}");
            Notify?.Invoke($"Available funds: {cash}");
        }

    }
}
