
using _02_11_2022;

Invoice invoice1 = new Invoice();
invoice1.Title.Date = DateTime.Today;
invoice1.Title.Number = "A-10015";
invoice1.Title.From = "Sportsman's LLC";
invoice1.Title.To = "Petrov inc.";

invoice1.Body.Goods = new Goods[]
{
        new Goods("Valenki"),
        new Goods("Shovel"),
        new Goods("Paper Towel")
};

invoice1.Footer.StorekeeperSurname = "Stepanov A.I.";
invoice1.Footer.ForwarderSurname = "Ivanov P.T.";

invoice1.PrintInvoice();

Invoice invoice2 = new Invoice();
invoice2.Title.Date = DateTime.Today;
invoice2.Title.Number = "A-10025";
invoice2.Title.From = "Target";
invoice2.Title.To = "Matvienko S.K";

invoice2.Body.Goods = new[]
{
    new Goods("Laptop"),
    new Goods("Filament"),
    new Goods("Apple")
};

invoice2.Footer.StorekeeperSurname = "Levy U.I.";
invoice2.Footer.ForwarderSurname = "Prohorov S.P";

invoice2.PrintInvoice();

Invoice Invoice3 = new Invoice();





