//Define a loop that defines a variable with the value 0 and stops at 20. Increase the value of the variable at every iteration. Decide what loop fits this problem best. Print a message to the console, including the variable's value for every iteration.

for (int i = 0; i < 20; i++)
{
  Console.WriteLine($"{i} --- iteration");
}
Console.WriteLine();
//Extend the previously created solution by only printing a message for values higher than 10. Decide what building block suits this problem best.

for (int i = 0; i < 20; i++)
{
  if (i > 10)
    Console.WriteLine($"{i} --- greater than 10");
}


// Write a program that prints a happy birthday based on user input. Ask the user for his age and reply on the console with a happy birthday message mentioning the user input.
Console.WriteLine("Hey how old are you?");
string? age = Console.ReadLine();
Console.WriteLine($"Happy Birthday! you are {age} years old  ");
