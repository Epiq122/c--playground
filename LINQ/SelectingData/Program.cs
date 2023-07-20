var persons = new List<Person>
{
    new Person("John", "Doe", 42),
    new Person("Jack", "Bower", 36),
    new Person("Zack", "Berouche", 12),
    new Person("Freddy", "Krueger", 9),
    new Person("Kevin", "McCallister", 8)
};

var lastNames = persons.Select(person => person.LastName);
foreach (var lastName in lastNames)
{
  Console.WriteLine(lastName);
}

var ageBetween20and30 = persons.Where(person => person.Age >= 5 && person.Age <= 15).Select(person => person.Age);
foreach (var age in ageBetween20and30)
{
  Console.WriteLine(age);
}

Console.WriteLine();

// first method
var firstPerson = persons.First();
var anotherPerson = persons.FirstOrDefault();



Console.WriteLine(firstPerson.FirstName);
Console.WriteLine(anotherPerson.FirstName);
// last method
var lastPerson = persons.Last();
Console.WriteLine(lastPerson.FirstName);

Console.WriteLine();
foreach (var person in persons.Skip(2).Take(2))
{
    Console.WriteLine(person.FirstName);
}


record Person(string FirstName, string LastName, int Age);