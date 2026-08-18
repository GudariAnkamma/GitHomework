using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nominal = Int32.Parse(GetInput("Input the nominal of the trade:"));
            double tradePrice = Double.Parse(GetInput("Input the trade price:"));

            TransactionType transactionType;
            while (!Enum.TryParse(GetInput("Input transaction type (Buy/Sell):"), true, out transactionType))
            {
                Console.WriteLine("Invalid input. Please enter 'Buy' or 'Sell'.");
            }

            double originalPrice = Double.Parse(GetInput("Input the original/booked price:"));

            int factor = transactionType == TransactionType.Buy ? 1 : -1;
            double currentValue = nominal * tradePrice * factor;

            // plFactor stays 0 for Buy by design — this assignment only defines
            // profit/loss for Sell transactions.
            int plFactor = transactionType == TransactionType.Sell ? 1 : 0;
            double profitLoss = (tradePrice - originalPrice) * nominal * plFactor;

            Console.WriteLine($"Current Value: {currentValue}");
            Console.WriteLine($"Profit/Loss: {profitLoss}");
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
