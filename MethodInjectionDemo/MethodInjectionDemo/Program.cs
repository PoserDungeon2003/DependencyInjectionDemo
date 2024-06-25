using MethodInjectionDemo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MethodInjectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IDepartment, Marketing>()
                .AddTransient<Employee>()
                .BuildServiceProvider();
            Employee employee1 = serviceProvider.GetService<Employee>();
            employee1.EmployeeId = 1;
            employee1.EmployeeName = "John";
            employee1.AssignDepartment(serviceProvider.GetService<IDepartment>());

            Employee employee2 = serviceProvider.GetService<Employee>();
            employee2.AssignDepartment(serviceProvider.GetService<IDepartment>());
            employee2.EmployeeId = 2;
            employee2.EmployeeName = "Jane";

            Console.WriteLine(employee1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(employee2);
            Console.ReadLine();
        }
    }
}
