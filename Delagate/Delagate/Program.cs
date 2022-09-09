
using Delagate;

var n = new Notifier();
n.Message = ShowMessage;
n.DoSomething();

    static void ShowMessage(string str)
{
    Console.WriteLine(str);
}


var account = new BankAccount();
//account.Notify += ShowMessage;
//account.Add(20);
//account.Add(30);
//account.Withdrawal(15);
//account.Withdrawal(25);

// the same with anonim method
Console.WriteLine(new string('-', 25));
//account.Notify += delegate(string message) { Console.WriteLine(message); };
account.Notify += (string message) => Console.WriteLine(message); // the same using lambda 
account.Add(20);
account.Add(30);
account.Withdrawal(15);
account.Withdrawal(25);
account.Notify -= ShowMessage;



