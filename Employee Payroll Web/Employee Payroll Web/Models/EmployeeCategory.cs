﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employee_Payroll_Web.Models
{
    public class EmployeeCategory
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

    }
}