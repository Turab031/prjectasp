using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty;


    }
}