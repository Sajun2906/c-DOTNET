// 1. A fintech company is building a Credit Card Transaction Analyzer. Developers must process transaction details with the correct C# datatypes to ensure accuracy, security, and performance.
// Question
// You are given the following transaction details:
// •	Transaction ID → alphanumeric, 12 characters
// •	Amount → can be up to ₹10,00,000.75
// •	IsInternational → True if the transaction is made outside India
// •	CustomerRating → value between 0.0 and 5.0 (precision up to 2 decimal places)
// •	TransactionTimestamp → date and time of the transaction
// •	RewardPoints → whole number (may reach up to millions)
// Task:
// 1.	Choose the most appropriate C# datatype for each field.
// 2.	Write a small C# code snippet declaring all these variables with sample values.


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
