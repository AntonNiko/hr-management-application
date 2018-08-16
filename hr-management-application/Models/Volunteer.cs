using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hr_management_application.Models
{
    public class Volunteer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public string StreetName { get; set; }
        public string HouseNum { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string PhoneNum { get; set; }
        public string Email { get; set; }

        public string Position { get; set; }
        public Wage EmployeeWage { get; set; }
        public Salary EmployeeSalary { get; set; }
        public Payroll PayrollInfo { get; set; }

        public string EmergContactName { get; set; }
        public string EmergContactPhone { get; set; }
    }
}