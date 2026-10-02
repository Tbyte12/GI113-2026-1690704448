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
            const double SmeltingRate = 0.25;
            const double SalvageRate = 0.3;
            const double MaximumAmount = 1000;
            // -----------------------------------------------------------------------

            // Menu ------------------------------------------------------------------
            Console.WriteLine("<===========--===========>");
            Console.WriteLine("<====> Forging Menu <====>");
            Console.WriteLine("<===========--===========>");

            // Action Input 
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose 'S' for smelting"); // ore to bar 
            Console.WriteLine("Choose 'B' for break down"); // bar to ore
            bool inputChoice = char.TryParse(Console.ReadLine(), out char forgeChoice);
            Console.WriteLine($"Chosen action: {forgeChoice}");

            // Amount Input
            Console.WriteLine("Your desired amount: ");
            bool inputAmount = double.TryParse(Console.ReadLine(), out double forgeAmount);
            Console.WriteLine($"Chosen amount: {forgeAmount}");

            if (!inputChoice || (forgeChoice != 'S' && forgeChoice != 's' && forgeChoice != 'B' && forgeChoice != 'b'))
            {
                Console.WriteLine("\n-------------------------------------------------------");
                Console.WriteLine("Please only choose between S(smelting) and B(Breakdown)!");
                Console.WriteLine("-------------------------------------------------------");
            }
            else if (!inputAmount || forgeAmount <= 0 || forgeAmount > MaximumAmount)
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("You're overwhelming the forge! Maximum's 1000.");
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                if (inputChoice && (forgeChoice == 'S' || forgeChoice == 's')) // Smelt
                {
                    double outputAmount = (forgeAmount * SmeltingRate);
                    Console.WriteLine($"-----===== Success! =====-----");
                    Console.WriteLine($"Formula, [Amount({forgeAmount}) x Smelt Rate({SmeltingRate})]");
                    Console.WriteLine($"You've smelted in total: {outputAmount} {Element}");
                    Console.WriteLine($"---------------------------------");
                }
                else // Salvage
                {
                    double outputAmount = (forgeAmount / SalvageRate);
                    Console.WriteLine($"-----===== Success! =====-----");
                    Console.WriteLine($"Formula, [Amount({forgeAmount}) / Salvage Rate({SalvageRate})]");
                    Console.WriteLine($"You've salvaged in total: {outputAmount} {Element}");
                    Console.WriteLine($"----------------------------------");
                }
            }
        }
    }
}

