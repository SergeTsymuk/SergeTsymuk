
using _038;

int number1 = 1, number2 = 2, number3 = 3;
bool b = false;

Mathm mathm = new Mathm();

int recevedResult = mathm.GetSum(number1, number2, number3, b);
Console.WriteLine($"As 'b' is '{b.ToString()}' Result is '{recevedResult}'!");

List<string> member = new List<string>();
member.Add("Stepan Razin");
member.Add("Anka Sidorova");
member.Add("Vlad Smirnov");

foreach (var item in member)
{

}