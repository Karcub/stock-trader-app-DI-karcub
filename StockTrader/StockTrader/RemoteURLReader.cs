using System.Net;

namespace stockTrader.StockTrader
{
    public static class RemoteUrlReader
    {
        public static string ReadFromUrl(string endpoint)
        {
            using var client = new WebClient();
            return client.DownloadString(endpoint);
        }
    }
}