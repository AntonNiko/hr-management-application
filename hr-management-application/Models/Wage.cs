using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hr_management_application.Models
{
    public class Wage
    {
        public Wage()
        {

        }

        public decimal WageValue { get; set; }
        public bool StatOvertimeValid { get; set; }
        public int DailyOvertimeHourStart { get; set; }
        public int WeeklyOvertimeHourStart { get; set; }
    }
}