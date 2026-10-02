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
            Console.WriteLine($"Player: I'm {recruitName}, sir!");
            Console.WriteLine("\nCommander: Oh, well get your arse ready and grab your sh--!");
            Console.WriteLine("Recruit: Aye aye sir!");
            Console.WriteLine("\n-----------------------------------");

            // 1st group condition 1 --------------------------------------------------------- ##

            Console.WriteLine("\nYour final rank summary:"); 
            Console.WriteLine($"\nName:, {recruitName} ");
            if (ranking == 5)
            {
                Console.WriteLine("Rank = Sergeant");
            }
            else if (ranking == 4)
            {
                Console.WriteLine("Rank = Specialist");
            }
            else if (ranking == 3)
            {
                Console.WriteLine("Rank = Corporal");
            }
            else if (ranking == 2)
            {
                Console.WriteLine("Rank = Pvt. 1st Class");
            }
            else
            {
                Console.WriteLine("Rank = Private");
            }

            // 1st group condition 2 --------------------------------------------------------- ##

            if (experience >= 90)
            {
                Console.WriteLine("EXP = Combat Ready");
                int recruitStam = 100;
                Console.WriteLine($"Stamina = {recruitStam}");
            }
            else if (experience >= 75)
            {
                Console.WriteLine("EXP = Highly Prepared");
                int recruitStam = 85;
                Console.WriteLine($"Stamina = {recruitStam}");
            }
            else if (experience >= 50)
            {
                Console.WriteLine("EXP = Prepared");
                int recruitStam = 70;
                Console.WriteLine($"Stamina = {recruitStam}");
            }
            else if (experience >= 25)
            {
                Console.WriteLine("EXP = Poorly Prepared");
                int recruitStam = 55;
                Console.WriteLine($"Stamina = {recruitStam}");
            }
            else
            {
                Console.WriteLine("EXP = Not Ready For Combat");
                int recruitStam = 40;
                Console.WriteLine($"Stamina = {recruitStam}");
            }
            Console.WriteLine("\n-----------------------------------");
        }
    }
}
