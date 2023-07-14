Movie movie = new Movie("The Dark Knight", "Christopher Nolan");
movie.PrintSummary();


public class Movie
{
  public string Title { get; set; }
  public string Director { get; set; }

  public Movie(string title, string director)
  {
    Title = title;
    Director = director;
  }
  public void PrintSummary()
  {
    string summary = $"{Title} by {Director}";
    Console.WriteLine(summary);
  }
  public int GetTitleLenghtWithoutWhitespaces()
  {
    string titleWithoutWhitespaces = Title.Replace(" ", "");
    return titleWithoutWhitespaces.Length;

  }

}


