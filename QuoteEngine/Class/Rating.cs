using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteEngine.Class
{
    public class Rating
    {
        public Decimal Input { get; set; }
        public Decimal OutPut { get; set; }
        public EnumTypeRating TypeRating { get; set; }
        public bool Enabled { get; set; }
        public bool Denied { get; set; }

        public Rating(Decimal prevQuote, EnumTypeRating type, Customer customer)
        {
            this.Input = prevQuote;
            this.TypeRating = type;
            this.Denied = false;
            this.Enabled = true;
            this.createRating(customer);
        }
        private void createRating(Customer customer)
        {
            switch (TypeRating)
            {
                case EnumTypeRating.BasePremium:
                    setRatingOutputBase(customer);
                    break;
                case EnumTypeRating.Age:
                    setRatingOutputAge(customer);
                    break;
                case EnumTypeRating.Sex:
                    setRatingOutputSex(customer);
                    break;
                case EnumTypeRating.Destination:
                    setRatingOutputDestination(customer);
                    break;
                case EnumTypeRating.Period:
                    setRatingOutputPeriod(customer);
                    break;
                case EnumTypeRating.Fee:
                    setRatingOutputFee();
                    break;

            }
            
        }

        private void setRatingOutputBase(Customer customer)
        {
            switch (customer.Travel.TripType)
            {
                case EnumTripType.SingleTrip:
                    this.OutPut = 20.00M;
                    break;
                case EnumTripType.Annual:
                    this.OutPut = 80.00M;
                    break;
            }
        }

        private void setRatingOutputAge(Customer customer)
        {

            if (customer.Age >= 71)
                Denied = true;
                        
            if (customer.Age <= 18 & customer.Age >= 0)
                this.OutPut = this.Input * 1.2M;

            if (customer.Age <= 45 & customer.Age >= 19)
                this.OutPut = this.Input * 1.0M;

            if (customer.Age <= 55 & customer.Age >= 46)
                this.OutPut = this.Input * 1.2M;

            if (customer.Age <= 65 & customer.Age >= 56)
                this.OutPut = this.Input * 1.8M;

            if (customer.Age <= 70 & customer.Age >= 66)
                this.OutPut = this.Input * 2.0M;
        }

        private void setRatingOutputSex(Customer customer)
        {
            switch (customer.Sex)
            {
                case EnumSex.Male:
                    this.OutPut = this.Input * 1.2M;
                    break;
                case EnumSex.Female:
                    this.OutPut = this.Input * 0.9M;
                    break;
            }
        }
        private void setRatingOutputDestination(Customer customer)
        {
            switch (customer.Travel.Destination)
            {
                case EnumDestination.UK :
                    this.OutPut = this.Input * 0.6M;
                    break;
                case EnumDestination.EU:
                    this.OutPut = this.Input * 1.0M;
                    break;
                case EnumDestination.World:
                    this.OutPut = this.Input * 1.4M;
                    break;

            }
        }
        private void setRatingOutputPeriod(Customer customer)
        {
            if (customer.Travel.TripType.Equals(EnumTripType.Annual))
            {
                this.Enabled = false;
                this.OutPut = this.Input;
            }
            if (customer.Travel.Days >= 31)
                Denied = true;

            if (customer.Travel.Days <= 7 & customer.Travel.Days  >= 1)
                this.OutPut = this.Input * 0.5M;


            if (customer.Travel.Days <= 14 & customer.Travel.Days >= 8)
                this.OutPut = this.Input * 0.9M;

            if (customer.Travel.Days <= 30 & customer.Travel.Days >= 15)
                this.OutPut = this.Input * 1.2M;
        }
        private void setRatingOutputFee()
        {
            this.OutPut = this.Input * 1.05M;
        }

        
    }
    
    public enum EnumTypeRating
    { 
        BasePremium = 0,
        Age = 1,
        Sex = 2,
        Destination = 3,
        Period = 4,
        Fee = 5
    }

    


}
