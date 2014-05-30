using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteEngine.Class
{
    public class Customer
    {
        public int Age {get;set;}
        public EnumSex Sex { get; set; }
        public Travel Travel { get; set; }

    }
    
    
    public enum EnumSex
    {
        Male = 1,
        Female = 2
    }
}
