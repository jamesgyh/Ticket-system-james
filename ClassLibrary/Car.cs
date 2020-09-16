using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibrary
{
    public  class Car
    {
        
        public string Licenseplate;

        public DateTime Date;

        public enum day
        {
            monday,
            tursday,
            wedensday,
            thursday,
            friday,
            saturday,
            sunday
        }

        public void switchday(day Day)
        {
            switch (Day)
            {
                case day.monday:
                     Price();
                    break;

                case day.tursday:
                     Price();
                    break;

                case day.wedensday:
                     Price();
                    break;

                case day.thursday:
                     Price();
                    break;

                case day.friday:
                     Price();
                    break;

                case day.saturday:
                    _ = 0.8 * Price();
                    break;

                case day.sunday:
                    _ = 0.8 * Price();
                    break;

            }
        }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual double Price()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return 240;
        }
        
        
        

        public virtual string VehicleType()
        {
            return "car";
        }
    }
}
