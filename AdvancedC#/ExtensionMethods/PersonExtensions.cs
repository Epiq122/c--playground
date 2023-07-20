namespace ExtensionMethods.Extensions;


// have to be static class
public static class PersonExtensions
{
  public static string GetFullName(this Person person)
  {
    return $"{person.FirstName} {person.LastName}";
  }
}
