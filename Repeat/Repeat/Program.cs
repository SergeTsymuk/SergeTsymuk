
using Repeat;

Test test = new Test();
test.ShowMessage();

//int x = 0;

//// запускаем пять потоков
//for (int i = 1; i < 6; i++)
//{
//    Thread mythread = new(Print);
//    mythread.Name = $"thread {i}";   // устанавливаем имя для каждого потока
//    mythread.Start();
//}

//void Print()
//{
//    x = 1;
//    for (int i = 1; i < 6; i++)
//    {
//        Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
//        x++;
//        Thread.Sleep(100);
//    }
//}

int x = 0;
object locker = new();  // объект-заглушка
// запускаем пять потоков
for (int i = 1; i < 6; i++)
{
    Thread myThread = new(Print);
    myThread.Name = $"Thread {i}";
    myThread.Start();
}


void Print()
{
    lock (locker)
    {
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(100);
        }
    }
}
//Task[] tasks = new Task[10];
//for (int i = 0; i < 10; i++)
//    {
//    tasks[i] = new Task(test.ShowMessage);
//    tasks[i].Start();
//    }
//Task.WaitAll(tasks);
//var y = 0;
