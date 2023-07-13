// Write a House class that requires the year it was built and the size (use units that you prefer) to initialize the object.
using System.Security.Cryptography;

House house = new House(2000);
bool canBeSold = house.CanBeSold(2023);
Console.WriteLine($"Can the house be sold? {canBeSold}");

class House
{

  public House(int yearBuilt)
  {
    YearBuilt = yearBuilt;
  }

  public int YearBuilt { get; private set; }

  // public int HowOld(int currentYear, int yearBuilt)
  // {
  //   return currentYear - yearBuilt;
  // }

  public bool CanBeSold(int currentYear)
  {
    int houseAge = CalculateAge(currentYear);
    return houseAge > 15;
  }

  private int CalculateAge(int currentYear)
  {
    return currentYear - YearBuilt;
  }
}