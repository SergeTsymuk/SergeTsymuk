using Birds_Classes;

Fish fish = new Fish();
fish.Move();

Canary canary = new Canary();
canary.Sing();
Console.WriteLine(canary.Color);
Ostrich ostrich = new Ostrich();
ostrich.Fly(nameof(ostrich));
Console.WriteLine(ostrich.Size);

