// See https://aka.ms/new-console-template for more information
internal class Program
{
    public delegate void NoParams();
    public delegate string WithParams(string name1, string name2);
    static void Main(string[] args)
    {
        NoParams noPrm = new(ShowMessage);
        noPrm();

        WithParams withPrm = new(ShowMessage);
        string value = withPrm("Me", "You");
        Console.WriteLine(value);
        Console.ReadLine();
    }
    private static void ShowMessage()
    {
        Console.WriteLine("Have Fun");
    }

    private static string ShowMessage(string name1, string name2)
    {
        Console.WriteLine($"{name1}, {name2} Have fun! ");
        return "with C#!";
    }
}