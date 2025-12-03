using System;

class TransactionDemo
{
    static void Main()
    {
        string transactionId = "TRX123456";
        decimal amount = 1000000.25m;
        bool isinternational = true;
        DateTime transactiontimestamp = DateTime.Now;
        int rewardpoints = 1500;

        Console.WriteLine("Transaction ID:{0}",transactionId);
        Console.WriteLine("Amount: {0}",amount);
        Console.WriteLine("Is International:{0}",isinternational);
        Console.WriteLine("Transaction Timestamp:{0}",transactiontimestamp);
        Console.WriteLine("Reward Points: {0}",rewardpoints);
    }

}