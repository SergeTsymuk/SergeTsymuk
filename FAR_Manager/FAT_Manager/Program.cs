using FAT_Manager;
using System.IO;

Dir dir = new Dir();

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

Console.Title = Convert.ToString(DateTime.Now);

ConsoleKeyInfo ckey;
Console.WriteLine("Press the Escape (Esc) key to quit: \n");
string rootPath = @"C:\";
int position = 0;

do
{
    Console.Clear();
    
    Console.WriteLine(new String('=', 50));
    Console.WriteLine("||    Name    \t\t\t\t\t||");
    Console.WriteLine("|| ...\t\t\t\t\t\t||");
    dir.ShowFolders(rootPath);
    dir.ShowFiles(rootPath);
    for (int i = 0; i < rootPath.Length; i++)
    {
        if (i == position)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"|| {rootPath[i]} \t\t\t\t\t\t||");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"|| {rootPath[i]} \t\t\t\t\t\t||");
        }
        
    }
    Console.WriteLine(new String('=', 50));
    
    ckey = Console.ReadKey();
    if (ckey.Key == ConsoleKey.UpArrow && position != 0) position--;
    if (ckey.Key == ConsoleKey.DownArrow && position != 50) position++;

    
    
} while (ckey.Key != ConsoleKey.Escape);


