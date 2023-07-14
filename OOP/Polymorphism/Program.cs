Person person = new Person();
Employee employee = new Employee();
Customer customer = new Customer();

Person person2 = new Person();
Person employee2 = new Employee();
Person customer2 = new Customer();

person.Greeting();
employee.Greeting();
customer.Greeting();

person2.Greeting();
employee2.Greeting();
customer2.Greeting();
public class Person
{

  public virtual void Greeting()
  {
    Console.WriteLine("Hello, I'm a regular person");
  }
}

public class Employee : Person
{
  public override void Greeting()
  {
    Console.WriteLine("Hello, I'm an employee");
  }
}

public class Customer : Person
{
  public override void Greeting()
  {
    Console.WriteLine("Hello, I'm a customer");
  }
}