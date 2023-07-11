using System.Globalization;

DateTime dateOfBirth = new DateTime(1986, 9, 5);
Console.WriteLine(dateOfBirth);
Console.WriteLine(dateOfBirth.DayOfWeek);

//computed values
DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime now = DateTime.Now;
Console.WriteLine(now);

//this is a common technique
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine(utcNow);


//date time parsing
DateTime localDate = DateTime.Parse("09,05,1986");
DateTime usDate = DateTime.Parse("09/05/1986", new CultureInfo("en-US"));
Console.WriteLine($"localDate: {localDate}, usDate: {usDate}");

//formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yy-MM-dd"));
Console.WriteLine(dateOfBirth.ToString("MM-dd-yy"));