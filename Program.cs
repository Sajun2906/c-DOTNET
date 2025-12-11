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
