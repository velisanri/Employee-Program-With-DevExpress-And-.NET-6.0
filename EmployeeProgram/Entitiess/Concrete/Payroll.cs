﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Concrete
{
    public class Payroll
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Mounth {  get; set; }
        public int Year { get; set; }
        public int ServiceDay { get; set; }
        public decimal GrossPay { get; set; }
        public decimal InsurancePremiumEmployeeShare { get; set; }
        public decimal IncomeTaxAssessment { get; set; }
        public decimal CumulaticeIncomeTaxAssessment { get; set; }
        public decimal NetPay { get; set; }

    }
}
