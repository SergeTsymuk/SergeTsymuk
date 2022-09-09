using Records;

MyClass instance = new MyClass();

MyStruct structA = new() { Value = 1}, structB = new() { Value = 1 };
Console.WriteLine($"structA.Equals(structB) == { structA.Equals(structB)}");

MyClass instanceA = new() { Value = 1 }, instanceB = new() { Value = 1 };
Console.WriteLine($"instanceA.Equals(instanceB) == { instanceA.Equals(instanceB)}");

MyRecord recordA = new() { Value = 1 }, recordB = new() { Value = 1 };
Console.WriteLine($"recordA.Equals(recordB) == { recordA.Equals(recordB)}");

AnImmutableType inst1 = new(), inst2 = new();
//inst1.Value = 22;
Console.WriteLine(inst1.Equals(inst2));

string text = new string("Hello");
Console.WriteLine(text.GetHashCode());
text += new string("World!");
Console.WriteLine(text.GetHashCode());
text = new string("Goodbye");
Console.WriteLine(text.GetHashCode());

Console.WriteLine(new string('-', 25));

string word1 = new string("book");
string word2 = new string("book");
Console.WriteLine(word1.GetHashCode());
Console.WriteLine(word2.GetHashCode());

MyType inst11 = new(), inst22 =new();
Console.WriteLine(inst11.GetHashCode());
Console.WriteLine(inst22.GetHashCode());
Console.WriteLine(inst11.Equals(inst22));

Console.WriteLine(new string('-', 25));

inst11.value = 22;
Console.WriteLine(inst11.GetHashCode());
Console.WriteLine(inst22.GetHashCode());
Console.WriteLine(inst11.Equals(inst22));

string str1 = "hello", str2 = "hello";
Console.WriteLine($"inst1 is a inst2 = {object.ReferenceEquals(str1, str2)}");

MyType inst01 = new(), inst02 =new();
Console.WriteLine($"inst1 is a inst2 = {object.ReferenceEquals(inst01, inst02)}");

Console.WriteLine(inst01.GetHashCode());
Console.WriteLine(inst02.GetHashCode());

Console.WriteLine(inst01.Equals(inst02));

Console.WriteLine(new string('-', 25));

inst01.value = 22;
Console.WriteLine(inst01.GetHashCode());
Console.WriteLine(inst02.GetHashCode());
Console.WriteLine(inst01.Equals(inst02));


Passport passport1 = new("Pierre", "Curie");
Console.WriteLine(passport1);

Passport passport2 = new("Maria", "Sklodowska");
Console.WriteLine(passport2);

string newLastName = passport2.LastName + "-" + passport1.LastName;
Passport passport3 = passport2 with {LastName = newLastName};
Console.WriteLine(passport3);