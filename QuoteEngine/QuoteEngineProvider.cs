using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuoteEngine.Class;
using QuoteEngine.Contracts;
using System.Collections;
using QuoteEngine.Builder;
using QuoteEngine.Builder.Contracts;
namespace QuoteEngine
{
    public class QuoteEngineProvider : IQuoteEngineProvider
    {
        readonly IBuilder _builder;
        public QuoteEngineProvider(IBuilder builder)
        {
            _builder = builder;
        }
        public string ProduceQuote(string input)
        {
            Customer customer = _builder.CreateCustomer(input);
            Quote quote = new Quote(customer);

            return _builder.CreateOutPutQuote(quote);
        }


    }
}
