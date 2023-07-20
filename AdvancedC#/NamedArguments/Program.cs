var person1 = new Person("John", 30, 7);
var person2 = new Person(age: 30, name: "John", luckyNumber: 7);
var person3 = new Person("John", age: 30, luckyNumber: 7);
var person4 = new Person("John", luckyNumber: 7, age: 30);



public class Person
{
  public Person(string name, int age, int luckyNumber)
  {
    Name = name;
    Age = age;
    LuckyNumber = luckyNumber;
  }
  public string Name { get; set; }
  public int Age { get; set; }
  public int LuckyNumber { get; set; }
}