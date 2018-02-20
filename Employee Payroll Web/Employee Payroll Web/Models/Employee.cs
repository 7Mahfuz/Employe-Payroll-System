using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Payroll_Web.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContatcNo { get; set; }

        public int CategoryId { get; set; }
        public string Category { get; set; }
        public EmployeeCategory EmployeeCategory { get; set; }

        public int Salary { get; set; }
    }
}