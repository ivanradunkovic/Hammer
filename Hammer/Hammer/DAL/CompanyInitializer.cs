using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Hammer.Models;

namespace Hammer.DAL
{
    public class CompanyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var logins = new List<Login>
            {
                new Login { loginNo = 1, loginUserName = "Bill", loginPassword = "ItsNotSoft" },
                new Login { loginNo = 2, loginUserName = "Jean", loginPassword = "trollsRule" }
            };

            logins.ForEach(s => context.Logins.Add(s));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { departmentNo = 1, departmentName = "Development", departmentLocation = "London" },
                new Department { departmentNo = 2, departmentName = "Development", departmentLocation = "Zurich" },
                new Department { departmentNo = 3, departmentName = "Development", departmentLocation = "Osijek" },
                new Department { departmentNo = 4, departmentName = "Sales", departmentLocation = "London" },
                new Department { departmentNo = 5, departmentName = "Sales", departmentLocation = "Zurich" },
                new Department { departmentNo = 6, departmentName = "Sales", departmentLocation = "Osijek" },
                new Department { departmentNo = 7, departmentName = "Sales", departmentLocation = "Basel" },
                new Department { departmentNo = 8, departmentName = "Sales", departmentLocation = "Lugano" }
            };

            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee { employeeNo = 1, employeeName = "Fred Davies", salary = 50000, departmentNo="4", lastModifyDate=DateTime.Parse("2020-01-30") },
                new Employee { employeeNo = 2, employeeName = "Bernard Katic", salary = 50000, departmentNo="3", lastModifyDate=DateTime.Parse("2020-01-29") },
                new Employee { employeeNo = 3, employeeName = "Rich Davies", salary = 30000, departmentNo="5", lastModifyDate=DateTime.Parse("2020-01-02") },
                new Employee { employeeNo = 4, employeeName = "Eva Dobos", salary = 30000, departmentNo="6", lastModifyDate=DateTime.Parse("2019-08-10") },
                new Employee { employeeNo = 5, employeeName = "Mario Hunjadi", salary = 25000, departmentNo="8", lastModifyDate=DateTime.Parse("2000-01-06") },
                new Employee { employeeNo = 6, employeeName = "Jean Michele", salary = 25000, departmentNo="7", lastModifyDate=DateTime.Parse("2017-01-10") },
                new Employee { employeeNo = 7, employeeName = "Bill Gates", salary = 25000, departmentNo="1", lastModifyDate=DateTime.Parse("2015-10-08") },
                new Employee { employeeNo = 8, employeeName = "Maja Janjic", salary = 30000, departmentNo="3", lastModifyDate=DateTime.Parse("2016-05-05") },
                new Employee { employeeNo = 9, employeeName = "Igor Horvat", salary = 30000, departmentNo="3", lastModifyDate=DateTime.Parse("2018-03-08") },

            };
        }
    }
}