int age = 36;

if (age >= 27 && age < 43)
{
  // int age = 55; - would not work since its already defined up top
  string generation = "Millenial";
  Console.WriteLine($"You're a {generation} because you are {age} years old.");
}
else
{
  string generation = "Unknown";
  Console.WriteLine($"You're a {generation}");
}
// Console.WriteLine(generation); - wont work as its inside a code block

for (int i = 0; i < 10; i++)
{
  Console.WriteLine(i);
}
// Console.WriteLine(i);  -- wont work as its inside a code block