using ExtensionMethods.Extensions;

var person = new Person("John", "Doe");
Console.WriteLine(person.GetFullName());
Console.WriteLine(person.HasId());


public interface IIdentification
{
  int Id { get; }
}


public static class IdentificationExtensions
{
  public static bool HasId(this IIdentification identification)
  {
    return identification.Id != 0;
  }
}



public class Person : IIdentification
{
  public Person(string firtstName, string lastName)
  {
    FirstName = firtstName;
    LastName = lastName;
  }
  public string FirstName { get; set; }
  public string LastName { get; set; }

  // public int Id => throw new NotImplementedException();
  public int Id
  {
    get
    {
      return 1;
    }
  }
}