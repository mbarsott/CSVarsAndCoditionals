using System;

namespace _3Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();

            System.Console.WriteLine("How many people are in your band?");
            int numberOfMembers = 0;
            if (!int.TryParse(Console.ReadLine(), out numberOfMembers))
            {
                System.Console.WriteLine("input was not valid");
                Environment.Exit(0);
            }

            if (numberOfMembers < 1)
            {
                System.Console.WriteLine("You must have at least 1 member"); Environment.Exit(0);
            }
            else if (numberOfMembers == 1)
            {
                System.Console.WriteLine(name + " is a solo");
            }
            else if (numberOfMembers == 2)
            {
                System.Console.WriteLine(name + " is a duo");
            }
            else
            {
                System.Console.WriteLine(name + " has " + numberOfMembers + " members.");
            }
        }
    }
}
