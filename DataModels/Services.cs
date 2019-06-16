using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Services
    {
        public Customers Customer { get; set; }
        public Vehicles Vehicle { get; set; }
        public String TypeOfServices { get; set; }
        public String Status { get; set; }
        public DateTime DateAndTimeOfTheService { get; set; }
        public String Duration { get; set; }
        public String Title { get; set; }
        public double CostOfService { get; set; }
        public String Note { get; set; }
        public Accounts Employee { get; set; }

    }
}
