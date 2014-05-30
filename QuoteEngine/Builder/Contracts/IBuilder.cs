using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuoteEngine.Class;
namespace QuoteEngine.Builder.Contracts
{
    public interface IBuilder
    {
        Customer CreateCustomer(string input);
        string CreateOutPutQuote(Quote quote);
    }
}
