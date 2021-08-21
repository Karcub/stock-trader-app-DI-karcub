namespace stockTrader.StockTrader
{
    public class Trader
    {
        private static Trader _instance;

        public static Trader Instance => _instance ??= new Trader();

        private readonly StockApiService _stockApiService;

        private Trader()
        {
            _stockApiService = new StockApiService();
        }
        
        /// <summary>
        /// Checks the price of a stock, and buys it if the price is not greater than the bid amount.
        /// </summary>
        /// <param name="symbol">the symbol to buy, e.g. aapl</param>
        /// <param name="bid">the bid amount</param>
        /// <returns>whether any stock was bought</returns>
        public bool Buy(string symbol, double bid) 
        {
            var price = _stockApiService.GetPrice(symbol);
            bool result;
            if (price <= bid) {
                result = true;
                _stockApiService.Buy(symbol);
                Logger.Instance.Log(
                    $"Purchased {symbol} stock at ${bid}, since its higher that the current price (${price})");
            }
            else {
                Logger.Instance.Log(
                    $"Bid for {symbol} was ${bid} but the stock price is ${price}, no purchase was made.");
                result = false;
            }
            return result;
    }
        
    }
}