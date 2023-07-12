Person person1 = new Person("Rob");
Person person2 = new Person("Bucky");
Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);
person1.PrintGreeting();
person2.PrintGreeting();
string greeting = person1.GetGreeting();
Console.WriteLine(greeting);



Math math = new Math();
int result = math.Sum(10, 10);
Console.WriteLine(result);

class Person
{

  // constructor
  public Person(string name)
  {
    Name = name;
  }

  // prop
  public string Name { get; private set; }

  public void PrintGreeting()
  {
    Console.WriteLine($"Welcome, {Name}!");
  }

  public string GetGreeting()
  {
    return $"Welcome, {Name}!";
  }

}

public class Math
{
  public static int Sum(int a, int b)
  {
    return a + b;
  }
}