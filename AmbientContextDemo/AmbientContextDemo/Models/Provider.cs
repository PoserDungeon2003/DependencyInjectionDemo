using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbientContextDemo.Models
{
    public abstract class DepartmentProvider
    {
        private static DepartmentProvider _current;
        public static DepartmentProvider Current
        {
            get
            {
                if (_current == null)
                    _current = new DefaultDepartmentProvider();
                return _current;
            }
            set
            {
                _current = value ?? new DefaultDepartmentProvider();
            }
        }
        public virtual Department Department { get; }
    }

    public class DefaultDepartmentProvider : DepartmentProvider
    {
        public override Department Department => new Engineering();
    }

    public class MarketingProvider : DepartmentProvider
    {
        public override Department Department => new Marketing();
    }
}
