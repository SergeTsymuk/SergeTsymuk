using Polindrom2;

Converter con = new Converter();
Console.WriteLine("Please Enter your word");
string entered = Console.ReadLine();

string converted = con.ConvertStr(entered);

Console.WriteLine(converted);