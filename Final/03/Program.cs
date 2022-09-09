Random random = new Random();

var numbers = new List<int>();
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));
numbers.Add(random.Next(99));

foreach (var item in numbers)
{
    Console.Write(item + ", ");
}

var sortedList = numbers.OrderBy(x => x);

Console.WriteLine();
Console.WriteLine(new string ('*',36));

foreach (var item in sortedList)
{
    Console.Write(item + ", ");
}

var square = sortedList.OrderByDescending(p=> p);

Console.WriteLine();
Console.WriteLine(new string('*', 36));

foreach (var item in square)
{
    if (item % 2 == 0)
    {
        Console.Write(item * item + ", ");
    }
    Console.Write((item + 1) * (item +1) + ", ");
}



