using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Reminders
    {
        public int RemindersID { get; set; }
        public DateTime DateOfCreated { get; set; }
        public DateTime DateOfSent { get; set; }
        public Customers Customer { get; set; }
        public String Status { get; set; }
 
    }
}
