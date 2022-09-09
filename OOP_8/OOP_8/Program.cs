using OOP_8;

Phone phone1 = new Phone()
{
    PhoneNumber = 251658483,
    PhoneWeight = 64.65,
    PhoneModel = "Samsung"
};
Phone phone2 = new Phone()
{
    PhoneWeight = 96.32,
    PhoneModel = "NOKIA",
    PhoneNumber = 356847258
};
Phone phone3 = new Phone()
{
    PhoneNumber = 265985354,
    PhoneModel = "Apple",
    PhoneWeight = 46.54,
};

Console.WriteLine("\nPhone # 01");
Console.WriteLine($"Phone MODEL: {phone1.PhoneModel}");
Console.WriteLine($"Phone Weight: {phone1.PhoneWeight}");
Console.WriteLine($"Phone Number: {phone1.PhoneNumber}");
phone1.ReceiveCall("Ivanov Ivan");
phone1.GetNumber(phone1.PhoneNumber);
phone1.ReceiveCall("Ivanov Ivan", phone1.PhoneNumber);

Console.WriteLine("\nPhone # 02");
Console.WriteLine($"Phone MODEL: {phone2.PhoneModel}");
Console.WriteLine($"Phone Weight: {phone2.PhoneWeight}");
Console.WriteLine($"Phone Number: {phone2.PhoneNumber}");
phone2.ReceiveCall("Petrov Anton");
phone2.GetNumber(phone2.PhoneNumber);
phone2.ReceiveCall("Petrov Anton", phone2.PhoneNumber);

Console.WriteLine("\nPhone # 03");
Console.WriteLine($"Phone MODEL: {phone3.PhoneModel}");
Console.WriteLine($"Phone Weight: {phone3.PhoneWeight}");
Console.WriteLine($"Phone Number: {phone3.PhoneNumber}");
phone3.ReceiveCall("Lavrov Ivan");
phone3.GetNumber(phone3.PhoneNumber);
phone3.ReceiveCall("Lavrov Ivan", phone3.PhoneNumber);

