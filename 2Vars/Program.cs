using System;

namespace _2Vars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();

            System.Console.WriteLine("How many people are in your band?");
            int numberOfMembers = int.Parse(Console.ReadLine());

            System.Console.WriteLine(name + " has " + numberOfMembers + " members.");
        }
    }
}
