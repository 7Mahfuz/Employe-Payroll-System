using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employee_Payroll_Web.Models
{
    public class EmployeePayrollManagementContext:DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCategory> Category { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}