internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Enter a String : \n");
        string enteredWord = Console.ReadLine();
        enteredWord.ToLower();
        string reversed = string.Empty;
        for (int i = 0; i < enteredWord.Length - 1; i++)
        {
            reversed += enteredWord[i];
        }
        if (reversed == enteredWord)
        {
            Console.WriteLine($" '{enteredWord}' is a POLINDROM");
        }
        else
        {
            Console.WriteLine($" '{enteredWord}' is NOT a Polindrom");
        }

    }

}