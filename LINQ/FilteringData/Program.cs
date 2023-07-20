//1. Data Source
var numbers = new List<int> { 0,1, 2, 3, 4, 5, 6 };

//2. Query Creation
var evenNumbers = numbers.Where(num => num % 2 == 0).ToList(); // only works with a single expression
var evenNumbers2 = numbers.Where(IsEven);


// works because it hasnt been executed yet
numbers.Add(12);
numbers.Add(9);

//3. Query Execution
foreach (var num in evenNumbers)
{
    Console.WriteLine("{0,1} " ,num);
}


static bool IsEven(int num)
{
    return num % 2 == 0;
}