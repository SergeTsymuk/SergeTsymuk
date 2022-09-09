List<int> GetFibanacci(int number)
{
    var result = new List<int>() { 0, 1 };
    int first = 0;
    int second = 1;
    int sum = 0;
    for (int i = 2; i < number; i++)
    {
        sum = first + second;
        first = second;
        second = sum;
        result.Add(sum);
    }

    return result;
}