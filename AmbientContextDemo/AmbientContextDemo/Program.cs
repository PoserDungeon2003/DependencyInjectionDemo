using AmbientContextDemo.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AmbientContextDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<Employee>()
                .AddTransient<MarketingProvider>()
                .AddTransient<DefaultDepartmentProvider>()
                .BuildServiceProvider();

            DepartmentProvider.Current = serviceProvider.GetService<MarketingProvider>();
            Employee employee1 = serviceProvider.GetService<Employee>();
            employee1.EmployeeId = 1;
            employee1.EmployeeName = "John";
            employee1.EmployeeDepartment = DepartmentProvider.Current.Department;

            Employee employee2 = serviceProvider.GetService<Employee>();
            employee2.EmployeeId = 2;
            employee2.EmployeeName = "Jane";
            employee2.EmployeeDepartment = DepartmentProvider.Current.Department;

            Console.WriteLine(employee1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(employee2);
            Console.ReadLine();
        }
    }
}
