using OOP_4;

Console.WriteLine("Please Enter Value of side1");
double side1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please Enter Value of side2");
double side2 = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(side1, side2);

double area = rectangle.AreaCalculator(side1, side2);
double perimeter = rectangle.PerimeterCalculator(side1, side2);

Console.WriteLine($"Area of our rectangular is: {area}.");
Console.WriteLine($"Perimeter of our rectangular is: {perimeter}.");
