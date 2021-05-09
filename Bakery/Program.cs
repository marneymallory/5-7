using System;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery\n");
            Console.WriteLine("Our daily deal for bread loaves are $5 each or buy two get one free. How many loaves of bread would you like to purchase?");
            string breadAmount = Console.ReadLine();
            int loafNumber = int.Parse(breadAmount);
            Bread newBread = new Bread(loafNumber);
            int breadCost = newBread.GetPrice();
            Console.WriteLine("Our daily deal for pastries is $2 each or 3 for $5. How many pastries would you like to purchase?");
            string pastryAmount = Console.ReadLine();
            int pastryNumber = int.Parse(pastryAmount);
            Pastry newPastry = new Pastry(pastryNumber);
            int pastryCost = newPastry.GetPrice();
            Console.WriteLine($"Your total is: ${breadCost + pastryCost}");
        }
    }
}
