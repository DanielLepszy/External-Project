using System;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class Accounts
    {
        public int AccountsID { get; set; }
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
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",
           ErrorMessage = "Password should contain at least 8 characters,"
           + " 1 number,1 uppercase and lowercase letter."
           + "\n Special characters ale allowed.")]
        public String Password { get; set; }

    }
}
