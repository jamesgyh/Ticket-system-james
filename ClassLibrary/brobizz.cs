using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class brobizz:Vehicles
   {
       public int OrigionalPrice;
        public override double Price()
        {
            return 0.95 * OrigionalPrice;
        }

        public override string VehicleType()
        {
            return "M C";
        }
    }
}
