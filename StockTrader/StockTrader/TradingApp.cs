using System;

namespace stockTrader.StockTrader
{

  internal class TradingApp
  {
    public static void Main(string[] args)
    {
	    var app = new TradingApp();
	    app.Start();
    }

    private void Start()
    {
	    Console.WriteLine("Enter a stock symbol (for example aapl):");
	    var symbol = Console.ReadLine();
	    Console.WriteLine("Enter the maximum price you are willing to pay: ");
	    double price;
	    while (!double.TryParse(Console.ReadLine(), out price))
	    {
		    Console.WriteLine("Please enter a number.");
	    }
	    
	    try
	    {
		    var purchased = Trader.Instance.Buy(symbol, price);
		    Logger.Instance.Log(purchased ? "Purchased stock!" : "Couldn't buy the stock at that price.");
	    } catch (Exception e) {
		    Logger.Instance.Log($"There was an error while attempting to buy the stock: {e.Message}");
	    }
        Console.ReadLine();
    }
  }
}