/*
* Student ID : 169704448
* Name       : MidTerm Exam 1
* Section    : 129D
* No.        : 22
* Course     : GI113 Computer Programming (GI)
*/
namespace Mid_Term_Exam_part_2_16904448
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Achivement points: ");
            bool A = int.TryParse(Console.ReadLine(), out int achievement);
            int B = achievement / 50;
            double C = achievement % 50;
            double D = C*0.20 ;

            Console.WriteLine($"Box amount: {B}");
            Console.WriteLine($"Remanining points: {C}");
            Console.WriteLine("Your rarity is...");
            if (B >= 10)
            {
                Console.WriteLine("Legendary");
            }
            else if (B >= 5)
            {
                Console.WriteLine("Epic");
            }
            else if (B >= 2)
            {
                Console.WriteLine("Rare");
            }
            else if (B > 0)
            {
                Console.WriteLine("Common");
            }
            else
            {
                Console.WriteLine("No Box");
            }
            Console.WriteLine($"Pity coins: {D}");
        }
    }
}
