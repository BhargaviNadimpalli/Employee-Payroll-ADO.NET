using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
   public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public char Gender { get; set; }
        public double BasicPay { get; set; }
        
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double Tax { get; set; }
        public double NetPay { get; set; }
        public DateTime startdate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
