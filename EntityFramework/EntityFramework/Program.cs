using EntityFramework;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };
    User sam = new User { Name = "Sam", Age = 27 };

    // добавляем их в бд
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.Users.Add(sam);
    db.SaveChanges();
    Console.WriteLine("Users Successfully Saved");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("List of Objects:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}