var movieQuotes = new Queue<string>();
movieQuotes.Enqueue("I'll be back");
movieQuotes.Enqueue("Hasta la vista, baby");
movieQuotes.Enqueue("No Fate But What We Make");

while (movieQuotes.Count > 0)
{
  var quote = movieQuotes.Dequeue();
  Console.WriteLine(quote);
}