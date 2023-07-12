//bool - boolean

using System.Threading.Channels;

bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

//char - must use single quotes
char c1 = 'a';
Console.WriteLine($"char: {c1}");


//int
int a = 1;
int b = 2;
int c = -6;
Console.WriteLine($"a: {a}, b: {b}, c: {c},");

//arithmetic operations ( cannot send out floating point numbers )
int multiply = b * c;
int divide = c / b;
int add = a + b;
int subtract = a - c;
Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, subtract: {subtract}");

//long
long i = 8999;
Console.WriteLine($"long: {i}");

//floating point numbers ( always use the suffix for the type
float f = 3.5f;
double g = 7.8d;
decimal dec = 7.15m;

Console.WriteLine($"f: {f}, g: {g}, dec: {dec}");

Console.WriteLine($"float calculation: {1.1111111f / 0.8324234f}");
Console.WriteLine($"float calculation: {1.1111111d / 0.8324234d}");
Console.WriteLine($"float calculation: {1.1111111m / 0.8324234m}");

//copying values
int a1 = 68;
int a2 = a1;
a1 = 88;
Console.WriteLine($"a1: {a1}, a2: {a2}");

//Nullable value types ( not having a defined value  needs the ? )
int? i1 = null;
bool? b1 = null;
Console.WriteLine($"int?: {i1}, bool?:{b1}");