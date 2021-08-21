using System;
using System.IO;

namespace stockTrader.StockTrader
{
    public class Logger
    {

        private static Logger _instance;

        public static Logger Instance => _instance ??= new Logger();

        public void Log(string message) {
            var msg = $"{DateTime.Now:yyyy/MM/dd hh:mm:ss} {message}";
            Console.WriteLine(msg);
            try
            {
                using var fileWriter = File.AppendText("log.txt");
                fileWriter.WriteLine(msg);
            }
            catch (IOException e) {
                Console.WriteLine($"Log file write failed :( {e}");
            }

        }        
    }
}