using System;

namespace JuliaRanMoreThanPranav
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last week Julia ran 30 miles more than Pranav. Julia ran 47 miles. How many miles did Pranav run?

            int juliaRan = 47;
            int juliaRanMore = 30;
            int pranavRan = juliaRan - juliaRanMore;
            Console.WriteLine("Pranav ran " + pranavRan + " miles.");
        }
    }
}
