var numbers = new List<int>();
var day = 31;
numbers.Add(day);

foreach (var number in numbers)
{
  Console.WriteLine($"The number is {number}");

}


var persons = new List<Person>();
var person1 = new Person("John");
persons.Add(person1);

foreach (var person in persons)
{
  Console.WriteLine($"The person name is {person.Name}");

}

public class Person
{
  public Person(string name)
  {
    Name = name;
  }
  public string Name { get; set; }
}