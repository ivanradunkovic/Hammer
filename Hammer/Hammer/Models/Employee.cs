using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hammer.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public decimal salary { get; set; }
        public int departmentId { get; set; }
        public DateTime lastModifyDate { get; set; }
        }
    }