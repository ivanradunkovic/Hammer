using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hammer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Hammer.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("CompanyContext")
        {
        }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}