using PropertyInjectionDemo.Models;

namespace PropertyInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "John Doe") 
            { 
                EmployeeDepartment = new Engineering()
            };
            Employee employee2 = new Employee(2, "Jane Doe") 
            { 
                EmployeeDepartment = new Marketing()
            };
            Console.WriteLine(employee1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(employee2);
            Console.ReadLine();
        }
    }
}
