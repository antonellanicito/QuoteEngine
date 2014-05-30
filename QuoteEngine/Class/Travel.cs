using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteEngine.Class
{
    public class Travel
    {
        public int Days {get;set;}
        public EnumTripType TripType {get;set;}
        public EnumDestination Destination {get;set;}
    }

    public enum EnumTripType
    {
        SingleTrip = 1,
        Annual = 2
    }
    public enum EnumDestination
    {
        UK = 1,
        EU = 2,
        World = 3
    }
}




