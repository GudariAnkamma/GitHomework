using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHomework
{
    enum TransactionType
    {
        Buy,
        Sell
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("Input the trade price:");
            userInput = Console.ReadLine();
            double tradePrice = Double.Parse(userInput);
            Console.WriteLine("Input transaction type (Buy/Sell):");
            userInput = Console.ReadLine();

            TransactionType transactionType = (TransactionType)Enum.Parse(typeof(TransactionType),userInput,true);
            Console.WriteLine("Input the original/booked price:");
            userInput = Console.ReadLine();
            double originalPrice = Double.Parse(userInput);
            int factor = transactionType == TransactionType.Buy ? 1 : -1;

            double currentValue = nominal * tradePrice * factor;
            int plFactor = transactionType == TransactionType.Sell ? 1 : 0;

            double profitLoss =
            (tradePrice - originalPrice) * nominal * plFactor;
            Console.WriteLine($"\nCurrent Value: {currentValue}");
            Console.WriteLine($"Profit/Loss: {profitLoss}");
        }
    }
}
