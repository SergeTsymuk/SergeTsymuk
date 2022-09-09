
using Collections;

List<Person> people = new List<Person>
{
    new Person { Name = "Serega"},
    new Person { Name = "Alex"}
};

//people.Add(new Person { Name = "Stats" });
//people.Sort();

//foreach (var p in people)
//{
//    Console.WriteLine(p.GetName());
//}
LinkedList<Person> linkedPeople = new LinkedList<Person>(people);

linkedPeople.AddLast(new LinkedListNode<Person>(new Person() { Name = "S"}));


people.Add(new Person { Name = "Stats" });
people.Sort();

foreach (var p in people)
{
    Console.WriteLine(p.GetName());
}