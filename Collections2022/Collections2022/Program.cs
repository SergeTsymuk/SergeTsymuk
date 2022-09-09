using Collections2022;
using System.Collections;


Helper helper = new Helper();

ArrayList arrayList = new ArrayList();
{
    arrayList.Add("Hello");
    arrayList.Add("people");
    arrayList.Add("How");
    arrayList.Add("are");
    arrayList.Add("You");
}
helper.ShowArrayList(arrayList);

List<int> list = new List<int>();
{
    list.Add(10);
    list.Add(20);
    list.Add(30);
    list.Add(40);
    list.Add(50);
}
helper.ShowList(list); // ??? how to use <T> ???

// adding 2 elements to the ArrayList
arrayList.Add("first"); 
arrayList.Add("second");
helper.ShowArrayList(arrayList);

// adding 2 elements to the List
list.Add(01);
list.Add(02);
helper.ShowList(list);

// Removing element with index 3 from our arrayLists
arrayList.RemoveAt(3);
helper.ShowArrayList(arrayList);

// Removing element with index 3 from our lists
list.RemoveAt(3);
helper.ShowList(list);

// Removing addad element
arrayList.Remove("first");
helper.ShowArrayList(arrayList);

list.Remove(1);
helper.ShowList(list);

//////////////////////////////////////////////////////  delegates  ///////////////////////////////////////////////////////
/// 

var newsReaderBasic = new NewsProvider();
newsReaderBasic.BasicNewsReader("Main news for today! Everything is OK!", "The weather is great!");

var newsReaderStandard = new NewsProvider();
newsReaderStandard.StandardNewsReader("Main news for today! Everything is OK!", "The weather is great today!", "No incidents were registered today");

var newsReaderPremium = new NewsProvider();
newsReaderPremium.PremiumNewsReader("Main news for today! Everything is OK!", "The weather is great today!", "No incidents were registered today",
    "Some funny stuff here...!", "Sprot news are only for premium members. Enjoy!!!");



var client1 = new Client("Ivan", "Petrov");
var client2 = new Client("Oleg", "Stepanov");
var client3 = new Client("Petr", "Losev");


public delegate string NewsReaderBasic(string news, string weather);
public delegate string NewsReaderStandard(string news, string weather, string incidents);
public delegate string NewsReaderPremium(string news, string weather, string incidents, string humor, string sport);

/// Сергей я понял что у меня проблема с пониманием как строятся программы. Это на сегодня все что я смог сдклать
/// Я пробовал создать градацию подкисчиков через (enum) но не смог его применить.
/// Не понимаю как можно осуществить следеющее условие/// при выходе новой новости в категории, подписчик получает услугу.
/// Скажите пожалуйста может вы преподаете репетиторство или можете кого подсказать. 


