using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInjectionDemo.Models
{
    public class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public IDepartment EmployeeDepartment;
        public Employee() { }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public void AssignDepartment(IDepartment department)
        {
            EmployeeDepartment = department ?? throw new ArgumentNullException("null");
        }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeId}, " +
                $"Employee Name: {EmployeeName}, " +
                $"Department: {EmployeeDepartment.DepartmentName}"; ;
        }
    }
}
