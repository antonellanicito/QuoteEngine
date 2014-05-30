using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteEngine.Contracts
{
    public interface IQuoteEngineProvider
    {
        string ProduceQuote(string input);
    }
}
