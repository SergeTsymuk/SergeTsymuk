
decimal tarif = 2;
decimal taxRate = 20;

Console.Write($"{"Please Enter min used in January: ", -35}");
decimal minJan = Convert.ToInt32(Console.ReadLine());

Console.Write($"{"Please Enter min used in February: ", -35}");
decimal minFeb = Convert.ToInt32(Console.ReadLine());

Console.Write($"{"Please Enter min used in March: ", -35}");
decimal minMarch = Convert.ToInt32(Console.ReadLine());

decimal totalMin = minJan + minFeb + minMarch;
decimal totalMinCost = totalMin * tarif;
decimal tax = totalMinCost / 100 * taxRate;

Console.WriteLine($"{"Total minutes used:", -25} {totalMin} min.");
Console.WriteLine($"{"Cost of all minutes:",-25} { totalMin * tarif}");
Console.WriteLine($"{"Tax paid:", -25 } {tax}");