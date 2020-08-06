using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContractType { get; set; }
        public decimal Amount { get; set; }
    }
}
