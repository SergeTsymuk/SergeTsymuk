string answer = " ";
Console.WriteLine("Enter number of cases");
int num = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("enter cases");

for (int i = 0; i < num; i++)
{
    double input = Convert.ToDouble(Console.ReadLine());

    answer = answer + GetIndexes(input) + " ";
}
Console.Write(answer);


static int GetIndexes(double input)
{
    if (input == 0)
        return 0;
    if (input == 1)
        return 1;
    int index = 2; double fibonachi = 1, previous = 1;
    while (fibonachi < input)
    {
        double temp = fibonachi;
        fibonachi = fibonachi + previous;
        previous = temp;
        index++;
    }

    return index;
}
