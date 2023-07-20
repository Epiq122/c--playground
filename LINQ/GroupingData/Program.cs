var employees = new List<Employee>
{
    new Employee("John", "Doe", "IT"),
    new Employee("Jack", "Bower", "Sales"),
    new Employee("Zack", "Berouche", "Scammer"),
    new Employee("Freddy", "Krueger", "Car Salesman"),
    new Employee("Kevin", "McCallister", "Scammer")
};

var personsByDepartment = employees.GroupBy(employee => employee.Department);

foreach (var department in personsByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");
    foreach (var employee in department)
    {
        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
    }
}




record Employee(string FirstName, string LastName, string Department);