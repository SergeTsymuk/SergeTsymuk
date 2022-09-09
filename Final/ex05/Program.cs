using ex05;
using System.IO;

Display dp = new Display();

ConsoleKeyInfo conKey;

Console.WriteLine("\t\t\tHello! Welcome to 'The Caffee!");
Console.WriteLine("\n\nPlease Enter number of available tables in 'The Caffee!");
int enteredNumber = Convert.ToInt32(Console.ReadLine());

do
{
    dp.DisplayMenu(ref enteredNumber);
    //conKey = Console.ReadKey();
} while (true);  // conKey.Key != ConsoleKey.Escape);



