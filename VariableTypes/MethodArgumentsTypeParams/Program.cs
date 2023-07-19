// reference types
var person = new Person("Axel");
Console.WriteLine($"person name: {person.Name}");

MethodParameters.ChangeName(ref person);
Console.WriteLine($"person name after method call: {person.Name}");




public class Person
{
  public Person(string name)
  {
    Name = name;
  }

  public string Name { get; set; }
}

public struct Rectangle
{
  public Rectangle(double width, double height)
  {
    // Width = width;
    // Height = height;
  }


  public double Width { get; set; }
  public double Height { get; set; }
}

public class MethodParameters
{
  public static void ChangeName(ref Person person)
  {
    person.Name = "Unknown";

    person = new Person("3 Ninjas");

  }
  public static void ChangeHeight(ref Rectangle rectangle)
  {
    rectangle.Height = 500;
    Console.WriteLine($"reactanngle height in method : {rectangle.Height}");
  }
}