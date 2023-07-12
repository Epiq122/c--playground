Console.WriteLine("Arithmetic Operators");
Console.WriteLine();
Console.WriteLine(" Plus, minus, multiplication, division");
int e = 2 + 7;
int f = 9 - 3;
int g = 10 * 4;
int h = 16 / 2;
Console.WriteLine($" e: {e}, f: {f}, g: {g}, h: {h}");

Console.WriteLine();
Console.WriteLine(" Increment and decrement");

int a = 7;
int b = a++;
Console.WriteLine($" a: {a}, b: {b}");

int c = 7;
int d = --c;

Console.WriteLine($" c: {c}, d: {d}");
Console.WriteLine();

Console.WriteLine(" Comparision Operators");
int k = 17;
int l = 15;
Console.WriteLine(k > 1); // true
Console.WriteLine(k < l); // false
Console.WriteLine(k >= l); // true
Console.WriteLine(k <= l); // false
Console.WriteLine();

Console.WriteLine(" Boolean logical operators");

bool isRegistered = false;
Console.WriteLine($"isRegistered: {isRegistered}"); // false
Console.WriteLine($"isRegistered NOT: {!isRegistered}"); // true

bool isWednesday = true;
bool isWeekend = false;
Console.WriteLine(isWednesday && isWeekend); // false; - both need to be true
Console.WriteLine(isWednesday || isWeekend); // true - only one has to be true
Console.WriteLine();

Console.WriteLine("Equality operators");
string myName = "Rob";
string myCountry = "Canada";
int myLuckyNumber = 9;

Console.WriteLine(myLuckyNumber != 5); // true does NOT equal
Console.WriteLine(myLuckyNumber == 9); // true equals to
                                       // Console.WriteLine(myLuckyNumber == myCountry); // false