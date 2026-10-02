namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Player Info ---------------------------------------------------------##

            Console.WriteLine("Your recruit's name: ");
            string recruitName = Console.ReadLine();

            Console.WriteLine("What is your military rank(1-5): "); // 1 = soldat, 5 = sergeant
            bool rank = int.TryParse(Console.ReadLine(), out int ranking);

            Console.WriteLine("What is your experience(Lvl, 1-100): ");
            bool exp = int.TryParse(Console.ReadLine(), out int experience);

            // Player Info Summary -------------------------------------------------##

            Console.WriteLine($"Recruit's name: , {recruitName}");
            Console.WriteLine($"Recruit's rank: , {ranking}");
            Console.WriteLine($"Recruit's experiences: , {experience}");

            // Game Start --------------------------------------------------------- ##

            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine("--      Military Recruitment     --");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("\nCommander: Hello recruit. Today's your examination. You're...");
            Console.WriteLine($"Recruit: I'm {recruitName}, sir!");
            Console.WriteLine("\nCommander: Oh, well get your arse ready and grab your sh--!");
            Console.WriteLine("Recruit: Aye aye sir!");
        }
    }
}
