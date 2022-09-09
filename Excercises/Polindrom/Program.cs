
Console.WriteLine("Please Enter your word");
string enteredWord = Console.ReadLine();

string reversed = string.Empty;

for (int i = enteredWord.Length - 1; i > -1 ; i--)
{
    reversed += enteredWord[i];
}

if (enteredWord == reversed)
{
    Console.WriteLine("Entered Word is a Polindrom ");
}
else
{
    Console.WriteLine("Entered Word is NOT a Polindrom ");
}

