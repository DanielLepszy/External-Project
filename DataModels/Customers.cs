using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataModels
{
    public class Customers
    {
        public int CustomersID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public String CompanyName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public String Name { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public String Surname { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        [Phone]
        public String PhoneNumber { get; set; }

    }
}
