using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientContextDemo.Models
{
    public interface IDepartment
    {
        int DepartmentId { get; set; }
        string DepartmentName { get; set; }
    }

    public class Department : IDepartment
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    public class Engineering : Department
    {
        public Engineering()
        {
            DepartmentName = "Engineering";
        }
    }

    public class Marketing : Department
    {
        public Marketing()
        {
            DepartmentName = "Marketing";
        }
    }
}
