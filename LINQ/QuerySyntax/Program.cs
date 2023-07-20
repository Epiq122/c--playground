var employees = new List<Employee>
{
    new Employee("John", "Doe", "Development"),
    new Employee("Jack", "Bower", "Sales"),
    new Employee("Zack", "Berouche", "Manager"),
    new Employee("Freddy", "Krueger", "Car Salesman"),
    new Employee("Kevin", "McCallister", "Development")
};


var selectedEmployees = from employee in employees
                        where employee.FirstName.StartsWith("J")
                        orderby employee.LastName
                        select employee;

foreach (var employee in selectedEmployees)
{
  Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
}

var employeesByDepartment = from employee in employees
                            group employee by employee.Department into groupedEmployees
                            orderby groupedEmployees.Key
                            select groupedEmployees;


foreach (var department in employeesByDepartment)
{
  Console.WriteLine($"Department: {department.Key}");
  foreach (var employee in department)
  {
    Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
  }

}



record Employee(string FirstName, string LastName, string Department);