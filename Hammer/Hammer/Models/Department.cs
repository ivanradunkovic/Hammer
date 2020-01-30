using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hammer.Models
{
    public class Department
    {
        public int departmentId { get; set; }
        public string departmentName { get; set; }
        public string departmentLocation { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}