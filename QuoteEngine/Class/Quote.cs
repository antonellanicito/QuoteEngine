using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteEngine.Class
{
    public class Quote
    {
        public List<Rating> ListOfRating { get; set; }
        public bool Denied { get; set; }

        public Quote(Customer customer)
        {
            ListOfRating = new List<Rating>();

            Denied = checkRating(customer, EnumTypeRating.BasePremium, 0M);
            if (!Denied)
                Denied = checkRating(customer, EnumTypeRating.Age, ListOfRating.Where(c => c.TypeRating.Equals(EnumTypeRating.BasePremium)).First().OutPut);
            if (!Denied)
                Denied = checkRating(customer, EnumTypeRating.Sex, ListOfRating.Where(c => c.TypeRating.Equals(EnumTypeRating.Age)).First().OutPut);
            if (!Denied)
                Denied = checkRating(customer, EnumTypeRating.Destination, ListOfRating.Where(c => c.TypeRating.Equals(EnumTypeRating.Sex)).First().OutPut);
            if (!Denied)
                Denied = checkRating(customer, EnumTypeRating.Period, ListOfRating.Where(c => c.TypeRating.Equals(EnumTypeRating.Destination)).First().OutPut);
            if (!Denied)
                Denied = checkRating(customer, EnumTypeRating.Fee, ListOfRating.Where(c => c.TypeRating.Equals(EnumTypeRating.Period)).First().OutPut);
        }

        private bool checkRating(Customer customer,EnumTypeRating type, decimal input)
        {
            Rating rating = new Rating(input, type, customer);
            ListOfRating.Add(rating);
            return rating.Denied;
        }
    }
}
