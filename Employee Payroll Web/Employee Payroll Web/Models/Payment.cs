using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Payroll_Web.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public string EmployeeName { get; set; }
        public int Salary { get; set; }

        public DateTime SalaryGivenDate { get; set; }

    }
}