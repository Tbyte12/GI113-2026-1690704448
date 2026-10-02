/*
* Student ID : 1690704448
* Name       : Assignment02
* Section    : 129D
* No.        : 22
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables -------------------------------------------------------------
            const string Element = "Iron";
            const double SmeltingRate = 0.5;
            const double SalvageRate = 0.25;
            const double MaxBatch = 1000;
            // -----------------------------------------------------------------------

            // Menu ------------------------------------------------------------------
            Console.WriteLine("<===========--===========>");
            Console.WriteLine("<====> Forging Menu <====>");
            Console.WriteLine("<===========--===========>");

            // Action
            Console.WriteLine("What do you want to do?"); 
            Console.WriteLine("Choose 'S' for smelting"); // ore to bar 
            Console.WriteLine("Choose 'B' for break down"); // bar to ore
            bool inputChoice = char.TryParse(Console.ReadLine(), out char choice);

            // Amount
            Console.WriteLine("Your desired amount: ");
            bool inputAmount = double.TryParse(Console.ReadLine(), out double amount);
        }
    }
}
