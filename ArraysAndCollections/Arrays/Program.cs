int[] array1 = new int[5];
array1[0] = 1;
array1[1] = 412;
array1[2] = 3443;
array1[3] = 24;
array1[4] = 15;
Console.WriteLine(array1);
Console.WriteLine(array1[0]);
Console.WriteLine(array1.Length);


// this is the new syntax for arrays if you know the values ( array initializer )
var array2 = new int[] { 1, 412, 3443, 24, 15 };
Console.WriteLine(array2);
Console.WriteLine(array2[0]);
Console.WriteLine(array2.Length);

var movies = new string[] { "The Matrix", "The Godfather", "The Lord of the Rings" };
Console.WriteLine(movies);
Console.WriteLine(movies[0]);
Console.WriteLine(movies.Length);

// alternative syntax for array initializer
string[] movies2 = { "The Matrix", "The Godfather", "The Lord of the Rings" };
Console.WriteLine(movies2);
Console.WriteLine(movies2[0]);
Console.WriteLine(movies2.Length);

// Uninitialized arrays
int[] array3 = new int[5];
Console.WriteLine(array3);
Console.WriteLine(array3[0]);
Console.WriteLine(array3.Length);


Person[] persons = new Person[3];
persons[0] = new Person("John");
persons[1] = new Person("Mary");
persons[2] = new Person("Bob");
Console.WriteLine(persons);
Console.WriteLine(persons[0].Name);
Console.WriteLine(persons.Length);

//  loop through an array with foreach
foreach (var person in persons)
{
  Console.WriteLine(person.Name);
}

public class Person
{
  public Person(string name)
  {
    Name = name;
  }
  public string Name { get; set; }
}
