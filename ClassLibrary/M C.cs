using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class M_C: Car
    {
       
        public string Licenseplate { get; set; }

        public DateTime Date { get; set; }

        public M_C(string licenseplate, DateTime date)
        {
            licenseplate = Licenseplate;
            if (licenseplate.Length>7)
            {
                throw new ArgumentException("too long LicensePlate");
            }

        }

        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "M C";
        }
    }
}
