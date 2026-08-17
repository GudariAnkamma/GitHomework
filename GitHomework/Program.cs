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

            Console.WriteLine("Input the price of the trade:");
            userInput = Console.ReadLine();
            decimal price = Decimal.Parse(userInput);

            Console.WriteLine("Input the transaction type (Buy/Sell):");
            userInput = Console.ReadLine();
            TransactionType trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);
        }
    }
}
