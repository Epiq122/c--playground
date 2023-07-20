var animals = new List<string> { "dog", "cat", "bird", "fish", "rabbit", "bear", "lion", "tiger", "elephant", "zebra" };

foreach (var animal in animals.OrderBy(animal => animal))
{
  Console.WriteLine(animal);

}
Console.WriteLine("----DECENDING----");

foreach (var animal in animals.OrderByDescending(animal => animal))
{
  Console.WriteLine(animal);

}

Console.WriteLine("----THENBY----");
var persons = new List<Person>
{
  new Person("John", "Buckner"),
  new Person("Jane", "Waters"),
  new Person("Mac", "Herouk"),
  new Person("Rick", "Stams"),
};

foreach (var person in persons.OrderBy(person => person.LastName).ThenBy(person => person.FirstName))
{
  Console.WriteLine($"{person.FirstName} {person.LastName}");
}


Console.WriteLine("--REVERSE--");
// how we added it in our code.
animals.Reverse();
foreach (var animal in animals)
{
  Console.WriteLine(animal);
}



record Person(string FirstName, string LastName);