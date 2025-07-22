using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
class Prac
{
    static void Main(String[] args)
    {

        Console.WriteLine("Enter City name");
        string pet = Console.ReadLine();

        Console.WriteLine("Enter Feul Price per litre");
        double fp = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Distance in KIlometers");
        double dist = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Feul type D for diseal and P for petrol");
        string type = Console.ReadLine();

        Console.WriteLine("Does The road have toll? True or FAlse");
        bool tool = Convert.ToBoolean(Console.ReadLine());

        Double toolamount;
        if (tool)
        {
            Console.WriteLine("Enter toll amount: ");
            toolamount = Convert.ToDouble(Console.ReadLine());

        }

        double average = 15;
        double fuelneeded = dist / average;
        double estcost = fuelneeded * fp;
        double roundtirp = estcost * 2;

        Console.WriteLine("City name: +pet ");
        Console.WriteLine("Distance: ");
        Console.WriteLine("Feul Cost Per Litre: ");
        Console.WriteLine("Average Mileage");
        Console.WriteLine("The Total Estimated Feul COst is Rs: " + estcost);
        Console.WriteLine("The round Trip cost is Rs " + roundtirp);

        if (dist > 100)
        {
            Console.WriteLine("The Trip is Long Distance");

        }
        ;
    } 
}
