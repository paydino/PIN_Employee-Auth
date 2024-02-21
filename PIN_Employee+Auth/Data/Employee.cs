using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIN_Add_Employees.Data
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Designation { get; set; }

    }
}
