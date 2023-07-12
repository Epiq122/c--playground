int age = 19;


if (age > 18) Console.WriteLine("You can have a beer");

// if - else 
if (age < 18)
{
    Console.WriteLine("You cannot vote");
}
else
{
    Console.WriteLine("Your good to vote");
}


string name = "Bucky";
// if - else - if
if (name == "Rob")
{
    Console.WriteLine("Welcome Rob");
}
else if (name == "Bucky")
{
    Console.WriteLine("Hey Buckster!");
}
else
{
    Console.WriteLine("Hey stranger");
}

// ternary conditional
int version = 4;
string productVersion = version == 4 ? "4.0" : "3.0";
Console.WriteLine(productVersion);