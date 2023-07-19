string content = "";
try
{
  content = File.ReadAllText("file.txt");
  Console.WriteLine("The file has been read successfully");
}
catch (FileNotFoundException exception)
{
  Console.WriteLine($"ERROR: The file '{exception.FileName}' was not found");
}
finally
{
  Console.WriteLine($"The content length is {content.Length}");
}

// this is the way to throw an exception using if (should be done this way for files)
var fileName = "this.txt";
if (File.Exists(fileName))
{
  var contents = File.ReadAllText(fileName);
  Console.WriteLine(contents);
}
else
{
  Console.WriteLine("The file does not exist, please check the file name, and try again, or create the file");
}