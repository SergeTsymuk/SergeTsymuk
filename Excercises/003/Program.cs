
Console.WriteLine("Please Enter your first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter your first number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber >= secondNumber)
{
    int seekingNumber = firstNumber - secondNumber;
    Console.WriteLine(firstNumber + "=" + secondNumber + "+" + seekingNumber);
}
else
{
    int seekingNumber = secondNumber - firstNumber;
    Console.WriteLine(secondNumber + "=" + firstNumber + "+" + seekingNumber);
}
