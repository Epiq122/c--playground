bool runAgain = true;
while (runAgain)
{
  Console.WriteLine("Welcome to the Epiq Calculator");
  Console.WriteLine();
  Console.WriteLine("Please enter 2 numbers you would like to calculate");
  Console.WriteLine("Enter number 1");
  int number1 = int.Parse(Console.ReadLine());
  Console.WriteLine("Enter number 2");
  int number2 = int.Parse(Console.ReadLine());
  Console.WriteLine("Now enter the arithmetic you would like to use, your options are (+, -, *, /)");
  string? choice = Console.ReadLine();

  int result = 0;
  switch (choice)
  {
    case "+":
      result = number1 + number2;
      break;
    case "-":
      result = number1 - number2;
      break;
    case "*":
      result = number1 * number2;
      break;
    case "/":
      result = number1 / number2;
      break;
    default:
      Console.WriteLine("Invalid choice");
      break;
  }
  Console.WriteLine($"The result is {result}");

  Console.WriteLine("Do you want to run the program again? (Y/N)");
  string? answer = Console.ReadLine();
  if (answer?.ToUpper() != "Y")
  {
    runAgain = false;
  }
}