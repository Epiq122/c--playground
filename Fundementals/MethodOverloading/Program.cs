Account account1 = new Account("Bucky");
Account account2 = new Account("Sally", 5000);
Console.WriteLine($"{account1.Owner} has {account1.Balance} in their account.");
Console.WriteLine($"{account2.Owner} has {account2.Balance} in their account.");

public class Account
{
  public decimal Balance { get; set; }
  public string Owner { get; set; }

  public Account(string owner)
  {
    Owner = owner;
    Balance = 0;
  }

  public Account(string owner, decimal balance)
  {
    Owner = owner;
    Balance = balance;
  }
}