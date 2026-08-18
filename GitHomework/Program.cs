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
            Console.WriteLine("Input the nominal of the trade:");
            string userInput = Console.ReadLine();
            int nominal = Int32.Parse(userInput);

            Console.WriteLine("Input the trade price:");
            userInput = Console.ReadLine();
            double tradePrice = Double.Parse(userInput);

            Console.WriteLine("Input transaction type (Buy/Sell):");
            userInput = Console.ReadLine();
            TransactionType transactionType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            int factor = transactionType == TransactionType.Buy ? 1 : -1;
            double currentValue = nominal * tradePrice * factor;
            Console.WriteLine($"Current Value: {currentValue}");
        }
    }
}
