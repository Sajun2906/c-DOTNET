// Smart Electricity Billing & Summary System (EnergyTech)
// Build a console application that computes monthly electricity bills for multiple consumers and produces a month-end summary report.
// Functional requirements:
// 1.	Read the number of consumers N.
// 2.	For each consumer read:
// o	ConsumerID (string)
// o	UnitsConsumed (integer)
// o	ConnectionType (code: 1 = Domestic, 2 = Commercial)
// 3.	Compute the base charge per consumer using the following slabs:
// o	Domestic: 0–100 → ₹1.50/unit; 101–300 → ₹2.50/unit; >300 → ₹4.00/unit
// o	Commercial: 0–200 → ₹5.00/unit; 201–500 → ₹6.50/unit; >500 → ₹8.00/unit
// 4.	Apply additional rules:
// o	Environmental surcharge = 3% of base charge
// o	If units > 500, add penalty ₹200
// o	If total after surcharge & penalty > ₹2000, apply discount 5% on the total
// 5.	For each consumer output:
// o	ConsumerID, ConnectionType (human readable), UnitsConsumed, BaseCharge, Surcharge, Penalty (if any), Discount (if any), FinalBill
// 6.	After processing all consumers, print a summary:
// o	Total consumers processed
// o	Total revenue (sum of final bills)
// o	Highest single bill amount and corresponding ConsumerID
// o	Count of Domestic vs Commercial consumers





using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of consumers: ");
        int n = int.Parse(Console.ReadLine());

        double total = 0, highest = 0;
        string highID = "";
        int dom = 0, com = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter ConsumerID, Units, Type(1=Domestic,2=Commercial):");
            string[] a = Console.ReadLine().Split(' ');

            string id = a[0];
            int units = int.Parse(a[1]);
            int type = int.Parse(a[2]);

            if (type == 1) dom++; else com++;

            double baseCharge = 0;

            // Base charge
            if (type == 1) // Domestic
            {
                if (units <= 100) baseCharge = units * 1.5;
                else if (units <= 300) baseCharge = units * 2.5;
                else baseCharge = units * 4.0;
            }
            else // Commercial
            {
                if (units <= 200) baseCharge = units * 5;
                else if (units <= 500) baseCharge = units * 6.5;
                else baseCharge = units * 8;
            }

            double sc = baseCharge * 0.03;   // Surcharge
            double pen = (units > 500) ? 200 : 0;
            double temp = baseCharge + sc + pen;
            double dis = (temp > 2000) ? temp * 0.05 : 0;
            double final = temp - dis;

            if (final > highest)
            {
                highest = final;
                highID = id;
            }

            total += final;

            string tname = (type == 1) ? "Domestic" : "Commercial";

            Console.WriteLine(id + " " + tname + " Units:" + units +
                              " Base:" + baseCharge +
                              " Surcharge:" + sc +
                              " Penalty:" + pen +
                              " Discount:" + dis +
                              " Final:" + final);
        }

        Console.WriteLine("\n--- Summary ---");
        Console.WriteLine("Total Consumers: " + n);
        Console.WriteLine("Total Revenue: " + total);
        Console.WriteLine("Highest Bill: " + highID + " " + highest);
        Console.WriteLine("Domestic: " + dom + " Commercial: " + com);
    }
}

