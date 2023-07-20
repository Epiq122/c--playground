using System.Collections;

var arrayList = new ArrayList();
var day = "Monday";
arrayList.Add(day);

var person1 = new Person("John");
arrayList.Add(person1);

var firstElement = arrayList[0];
Console.WriteLine($"The first element is {firstElement}");


public class Person
{
  public Person(string name)
  {
    Name = name;
  }
  public string Name { get; set; }
}

// Dont use ArrayList, its only good for legacy code