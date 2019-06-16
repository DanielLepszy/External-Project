using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Vehicles
    {
        public int VehiclesID { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public Customers Customer { get; set; }
        public String LicenceNumber { get; set; }
        public String VinNumber { get; set; }
        public String YearOfProduction { get; set; }
        public String Action { get; set; }

    }
}
