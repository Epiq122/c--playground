var person = new Person("John", 33);
var person1 = new Person("John", 33, 7);

var person3 = new Person("Buck", age: 33, luckyNumber: 17);
var person4 = new Person("Buck", luckyNumber: 17, age: 33, favoriteColor: "Red");

public class Person
{
  public Person(string name, int age, int luckyNumber = 66, string favoriteColor = "Blue")
  {
    Name = name;
    Age = age;
    LuckyNumber = luckyNumber;
    FavoriteColor = favoriteColor;
  }
  public string Name { get; set; }
  public int Age { get; set; }
  public int LuckyNumber { get; set; }
  public string FavoriteColor { get; set; }
}