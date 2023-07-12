// commonly used to data and input 

using System.Globalization;

string luckyNumber = "316";
int parsedLuckyNumber = int.Parse(luckyNumber);


// German way only they need to add 28,1
CultureInfo cultureInfo = new CultureInfo("de-DE");
double temperature = double.Parse("28.1", cultureInfo);

Console.ReadKey();