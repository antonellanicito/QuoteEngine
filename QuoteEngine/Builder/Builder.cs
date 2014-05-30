using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuoteEngine.Class;
using QuoteEngine.Builder.Contracts;
namespace QuoteEngine.Builder
{
    public class Builder : IBuilder
    {
        public Customer CreateCustomer(string input)
        {
            List<KeyValuePair<string, string>> listOfInput = new List<KeyValuePair<string, string>>();
            listOfInput = getList(input);
            return CreateCustomer(listOfInput);
        }

        public string CreateOutPutQuote(Quote quote)
        {
            StringBuilder sb = new StringBuilder();
            if (quote.Denied)
            {
                sb.Append("DECLINE:" + quote.ListOfRating.First(c => c.Denied).TypeRating.ToString());
                return sb.ToString();
            }
            foreach (Rating rating in quote.ListOfRating.Where(c=>c.Enabled) )
            {
                sb.AppendLine(rating.TypeRating.ToString() + "(" + Round(rating.OutPut - rating.Input) + "): " + Round(rating.OutPut));
            }
            sb.AppendLine("Total Premium:" + RoundDown(quote.ListOfRating.Single(c=>c.TypeRating.Equals(EnumTypeRating.Fee)).OutPut));
            return sb.ToString();
        }

        private List<KeyValuePair<string, string>> getList(string input)
        {
            input = input.Replace(Environment.NewLine, "|");
            input = input.EndsWith("|") ? input.Remove(input.Length - 1) : input;

            return input.Split('|').ToList().Select(c => new KeyValuePair<string, string>(c.Split(':').ToArray()[0].ToString(), c.Split(':').ToArray()[1].ToString())).ToList();


        }
        private Customer CreateCustomer (List<KeyValuePair<string,string>> inputList)
        {
           
            return new Customer
            {
                Age = Convert.ToInt32(inputList.Single(c => c.Key.Equals("Age")).Value),
                Sex = (EnumSex)Enum.Parse(typeof(EnumSex), inputList.Single(c => c.Key.Equals("Sex")).Value, true),
                Travel = new Travel
                {
                    Destination = (EnumDestination)Enum.Parse(typeof(EnumDestination), inputList.Single(c => c.Key.Equals("Destination")).Value, true),
                    TripType = (EnumTripType)Enum.Parse(typeof(EnumTripType), inputList.Single(c => c.Key.Equals("Type")).Value, true),
                    Days = (EnumTripType)Enum.Parse(typeof(EnumTripType), inputList.Single(c => c.Key.Equals("Type")).Value, true)==EnumTripType.SingleTrip ? Convert.ToInt32( inputList.Single(c => c.Key.Equals("PeriodOfTravel")).Value.Trim()) : -1
                }

            };
        }
        private string Round(decimal var)
        {
            return String.Format("{0:0.00}", var);
        }
        private string RoundDown(decimal var)
        {
            decimal down = Math.Floor(var * 100M) / 100M;
            return String.Format("{0:0.00}", down);
        }

    }
}
