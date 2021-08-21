using NUnit.Framework;
using stockTrader.StockTrader;

namespace stockTraderTests.StockTrader
{
    public class StockApiServiceTest
    {
        [Test] // everything works
        public void TestGetPriceNormalValues()
        {
            var toTest = new StockApiService();
        }

        [Test] // readFromURL threw an exception
        public void TestGetPriceServerDown()
        {
        }

        [Test] // readFromURL returned wrong JSON
        public void TestGetPriceMalformedResponse() 
        {
        }
    }
}