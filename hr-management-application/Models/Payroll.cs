using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hr_management_application.Models
{
    public class Payroll
    {
        public Payroll()
        {

        }

        public string BankName { get; set; }
        public string AccountType { get; set; }
        public string TransitNum { get; set; }
        public string AccountNum { get; set; }
        public string EndFormDelivery { get; set; }
    }

}