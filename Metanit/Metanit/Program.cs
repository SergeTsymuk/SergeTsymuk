using Metanit;
Console.WriteLine(new string('*', 30));

var people = new List<Person>
{
    new Person ("Tom", 23, "Minsk", false),
    new Person ("Bob", 27, "Moscow", true),
    new Person ("Sam", 29, "King of Prusia", true),
    new Person ("Alice", 24, "Kiev", false),
    new Person ("Fon", 55, "Gili", false),
    new Person ("Ron", 71, "Dalas", false),
    new Person ("Hohe", 23, "New York", false),
    new Person ("Shon", 13, "Kiev", false),
    new Person ("Mark", 41, "Sluck", true),
    new Person ("Nove", 32, "Phily", false),
    new Person ("Lolin", 18, "Stambul", true),
    new Person ("Spenser", 15, "Wayn", true)
};

var selected1 = people.Where(p => p.Name.StartsWith("S"));
foreach (var item in selected1)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine(new string('-',30));
var selected2 = people.Where(p =>p.Age > 30);
foreach (var item in selected2)
{
    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
}

Console.WriteLine(new string('-', 30));
var selected3 = people.Where (p => p.IsEmployee == true);
foreach (var item in selected3)
{
    Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
}

Console.WriteLine(new string('-', 30));
var selected4 = people.Where(p => p.City.ToLower() == "minsk");
foreach (var item in selected4)
{
    Console.WriteLine($"Name: {item.Name}, {item.City}");
}

Console.WriteLine(new string('-', 30));
var selected5 = people.OrderBy((p) => p.Age);
foreach (var item in selected5)
{
    Console.WriteLine($"Name: {item.Name}, {item.Age}");
}

Console.WriteLine(new string('-', 30));
var selected6 = people.Sum(p => p.Age);
Console.WriteLine(selected6);

Console.WriteLine(new string('-', 30));
var selected8 = people.Max(p => p.Age);
Console.WriteLine(selected8);

Console.WriteLine(new string('-', 30));
var cities = people.GroupBy(p => p.City);

foreach (var city in cities)
{
    Console.WriteLine($"{city.Key}\n");
    foreach (var person in city)
    {
        Console.WriteLine($" - {person.Name}");
    }
    Console.WriteLine(new string('-', 15));
}


Console.WriteLine(new string('-', 30));
var cities2 = people.GroupBy(p => p.City);
var last = cities2.Last();
Console.WriteLine($"\n * {last.Key} *");