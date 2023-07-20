var movies = new Stack<string>();
movies.Push("The Matrix");
movies.Push("The Godfather");
movies.Push("The Lord of the Rings");
movies.Push("The Dark Knight");

var lastMovie = movies.Pop();
Console.WriteLine($"The last movie is {lastMovie}");

var previousMovie = movies.Peek();
Console.WriteLine($"The previous movie is {previousMovie}");




foreach (var movie in movies)
{
  Console.WriteLine(movie);
}

