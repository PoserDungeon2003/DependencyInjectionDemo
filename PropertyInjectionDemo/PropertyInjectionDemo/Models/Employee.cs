using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyInjectionDemo.Models
{
    public class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        private IDepartment _department;
        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }

        public IDepartment EmployeeDepartment
        {
            get
            {
                if (this._department == null)
                    this.EmployeeDepartment = new Engineering();
                return this._department;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Department cannot be null");
                if (this._department != null)
                    throw new InvalidOperationException("Department has already been set");
                this._department = value;
            }
        }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeId}, " +
                $"Employee Name: {EmployeeName}, " +
                $"Department: {EmployeeDepartment.DepartmentName}";
        }
    }
}
