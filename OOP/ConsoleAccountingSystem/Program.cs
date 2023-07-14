Console.WriteLine("Welcome to the Console Accounting System!");
CheckingAccount account = new CheckingAccount(100, 0);
account.PrintAccountInfo();
PremiumCheckingAccount premiumAccount = new PremiumCheckingAccount(200, 0);
premiumAccount.PrintAccountInfo();
// print balance for both accounts
Console.WriteLine($"Account balance: {account.Balance}");
Console.WriteLine($"Premium account balance: {premiumAccount.Balance}");
// deposit $2000 into checking
account.Deposit(2000);
// deposit $6000 into premium checking
premiumAccount.Deposit(6000);
// print balance for both accounts
Console.WriteLine($"Account balance: {account.Balance}");
Console.WriteLine($"Premium account balance: {premiumAccount.Balance}");
// transfer 2000 from premium to checking
premiumAccount.Transfer(account, 2000);
// print balance for both accounts
Console.WriteLine($"Account balance: {account.Balance}");
Console.WriteLine($"Premium account balance: {premiumAccount.Balance}");
// calculate interest for both accounts on 3%
decimal accountInterest = account.CalculateInterest(0.03m);
decimal premiumAccountInterest = premiumAccount.CalculateInterest(0.03m);
// print interest for both accounts
Console.WriteLine($"Account interest: {accountInterest}");
Console.WriteLine($"Premium account interest: {premiumAccountInterest}");
// print balance for both accounts with interest added
Console.WriteLine($"Account balance: {account.Balance + accountInterest}");
Console.WriteLine($"Premium account balance: {premiumAccount.Balance + premiumAccountInterest}");


// A checking account has an ID (number) and a balance (decimal number).
public class CheckingAccount
{
  public int AccountID { get; set; }
  public decimal Balance { get; set; }

  //You should be able to set a starting balance when creating a checking account.
  public CheckingAccount(int accountID, decimal startingBalance = 0)
  {
    AccountID = accountID;
    Balance = startingBalance;
  }

  //You should be able to deposit money (decimal number) at any time after creating a checking account.
  public void Deposit(decimal amount)
  {
    Balance += amount;
  }

  // You should be able to calculate interest based on the current balance of the checking account and an input.
  public virtual decimal CalculateInterest(decimal rate)
  {
    return Balance * rate;
  }

  // You should be able to print the ID and the current balance of a checking account at any time.


  public void PrintAccountInfo()
  {
    Console.WriteLine($"Account ID: {AccountID}, Balance: {Balance}");
  }

  // You should be able to transfer money from one account to another at any time.


  public void Transfer(CheckingAccount destinationAccount, decimal amount)
  {
    if (Balance >= amount)
    {
      Balance -= amount;
      destinationAccount.Deposit(amount);
    }
    else
    {
      Console.WriteLine("Insufficient funds to complete transfer.");
    }
  }
}

// The premium account has the same behavior as the checking account. The only difference is that the premium account gets a 1% extra interest on top of the user input.
public class PremiumCheckingAccount : CheckingAccount
{
  public decimal InterestRate { get; set; }

  public PremiumCheckingAccount(int accountID, decimal startingBalance = 0, decimal interestRate = 0)
    : base(accountID, startingBalance)
  {
    InterestRate = interestRate;
  }

  public override decimal CalculateInterest(decimal rate)
  {
    return base.CalculateInterest(rate + 0.01m);
  }
}


