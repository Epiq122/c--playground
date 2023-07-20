var grades = new Dictionary<string, int>{
  {"John", 90},
  {"Mary", 80},
  {"Bob", 70}
};
grades.Add("Jane", 100);
grades["Joe"] = 95;


foreach (var grade in grades)
{
  Console.WriteLine($"The grade of {grade.Key} is {grade.Value}");
}


Console.WriteLine(grades.ContainsKey("Jack"));
grades.Remove("John");
grades.Values.ToList().ForEach(Console.WriteLine);
grades.TryGetValue("Mary", out int maryGrade);