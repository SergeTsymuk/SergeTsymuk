using ex04;

Drawer dr = new Drawer();

Console.WriteLine("Please Enter the number!");
string entered = Console.ReadLine();
int enteredNum = Convert.ToInt32(entered);

dr.DrawPicture(enteredNum);