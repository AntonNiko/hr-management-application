using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hr_management_application.Models
{
    public class Salary
    {
        public Salary()
        {

        }

        public decimal SalaryValue { get; set; }
        public bool OvertimeValid { get; set; }
        public int DailyOvertimeHourStart { get; set; }
        public int WeeklyOvertimeHourStart { get; set; }
    }
}