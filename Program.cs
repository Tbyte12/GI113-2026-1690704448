namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------
            // Screen 1
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|           CHARACTER DESIGN            |");
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("Name your character: ");
            string charName = Console.ReadLine();
            Console.WriteLine("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");
            //--------------------------------------------------------------------------------------------------
            // Screen 2
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|               ITEM SHOP               |");
            Console.WriteLine("+---------------------------------------+");
            Console.Write("How many potions: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);

            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            //--------------------------------------------------------------------------------------------------
            // Screen 3
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|              SET VOLUME               |");
            Console.WriteLine("+---------------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");
            //--------------------------------------------------------------------------------------------------
            // Screen 4
            //--------------------------------------------------------------------------------------------------
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("|             NEW SAVE FILE             |");
            Console.WriteLine("+---------------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
