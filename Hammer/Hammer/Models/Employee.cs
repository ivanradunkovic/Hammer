using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hammer.Models
{
    public class Employee
    {
        public int employeeNo { get; set; }
        public string employeeName { get; set; }
        public string salary { get; set; }
        public string departmentNo { get; set; }
        public DateTime lastModifyDate { get; set; }

    }
}