string message = "Welcome to my nightmare";
Console.WriteLine(message);

// empty string
string emptyMessage = string.Empty;

string stringWithDoubleQuote = "This is a string with a double quote: \"";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\temp";
Console.WriteLine(filePath);

string filePath2 = @"C:\temp";
Console.WriteLine(filePath2);

//string length
Console.WriteLine(filePath2.Length);

//string concatenation
string firstName = "Rob";
string lastName = "Gleason";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

//string interpolation
string fullName2 = $"{firstName} {lastName}";
Console.WriteLine(fullName2);
Console.WriteLine($"The result is: {66 * 100}");

//substring
string first5Characters = fullName.Substring(0, 5);
Console.WriteLine(first5Characters);