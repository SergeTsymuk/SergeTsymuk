using Test05;

DateTime time = new DateTime();
MyString myString = new MyString();

DateTime ct = DateTime.Now;
time = ct.AddYears(5501);
Console.WriteLine(time.ToString());

string text = "hello every one!";
myString.ReverseString(text);
