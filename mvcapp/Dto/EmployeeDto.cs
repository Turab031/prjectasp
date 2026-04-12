using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcapp.Dto
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;


        public string Email { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty;
    }
}