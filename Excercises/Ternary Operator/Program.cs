
int x = 10, y = -5;
string quadrant = (y >= 0 && x >= 0) ? "first quadrant" : 
    (y >= 0 && x < 0) ? "second quadrant" : 
    ( x <= 0 && y <=0) ? "third quadrant" : "fourth quadrant";

Console.WriteLine(quadrant);

