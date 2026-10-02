/*
* Student ID :1690704448
* Name       :Lab 06
* Section    :129D
* No.        :22
* Course     :GI113 Computer Programming (GI)
*/
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oppsHp = 100;
            int oppsPunchDmg = 50;
            int playerHp = 100;
            int punchDmg = 50;
            int kickDmg = 100;

            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
            //Class's Lecture is saved in separate note****
            //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

            // Player Info ---------------------------------------------------------##

            Console.WriteLine("Your name: ");
            string boxerName = Console.ReadLine();

            Console.WriteLine("Your weight: ");
            bool wOk = int.TryParse(Console.ReadLine(), out int weight);

            Console.WriteLine("What is your experience(Lvl, 1-100): ");
            bool expOk = int.TryParse(Console.ReadLine(), out int experience);
            if (!expOk || experience < 1 || experience > 100)
            {
                Console.WriteLine("Invalid input. Experience set to 0.");
                experience = 0;
            }

            // Game Start --------------------------------------------------------- ##

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("--        Boxing Showdown        --");
            Console.WriteLine("-----------------------------------");

            // 1st condition ----------------------------------------------------------- ##

            if (weight >= 90)
            {
                Console.WriteLine("Class = Heavyweight");
            }
            else if (weight >= 70)
            {
                Console.WriteLine("Class = Middleweight");
            }
            else if (weight >= 60)
            {
                Console.WriteLine("Class = Lightweight");
            }
            else if (weight >= 50)
            {
                Console.WriteLine("Class = Featherweight");
            }
            else
            {
                Console.WriteLine("Class = Flyweight");
            }
            //--------------------------------------------------------------------------
            if (experience >= 90)
            {
                Console.WriteLine("EXP = Combat Ready");
            }
            else if (experience >= 75)
            {
                Console.WriteLine("EXP = Highly Prepared");
            }
            else if (experience >= 50)
            {
                Console.WriteLine("EXP = Prepared");
            }
            else if (experience >= 25)
            {
                Console.WriteLine("EXP = Poorly Prepared");
            }
            else
            {
                Console.WriteLine("EXP = Not Ready For Combat");
            }
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\n===================================");
            // 2nd condition --------------------------------------------------------- ##

            Console.WriteLine("\n1st Turn");

            Console.WriteLine("CHOICE 1: PUNCH");
            Console.WriteLine("CHOICE 2: KICK");
            Console.WriteLine("CHOICE 3: BLOCK");

            Console.WriteLine("CHOOSE YOUR NEXT MOVE(1-3)");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, please only choose from 1-3!");
            }
            else if (choice == 1)
            {
                oppsHp -= punchDmg;
                if (oppsHp <= 0)
                {
                    Console.WriteLine("Opponent is KO'd");
                }
                else
                {
                    Console.WriteLine($"Opponent took {punchDmg} DMG! Opponent has {oppsHp} HP left!");
                }
            }
            else if (choice == 2)
            {
                oppsHp -= kickDmg;
                if (oppsHp <= 0)
                {
                    Console.WriteLine("Opponent is KO'd");
                }
                else
                {
                    Console.WriteLine($"Opponent took {kickDmg} DMG! Opponent has {oppsHp} HP left!");
                }
            }
            else
            {
                Console.WriteLine("Opponent decided to punch you!");
                playerHp -= oppsPunchDmg;
                if (playerHp < 0)
                {
                    Console.WriteLine("You've been KO'd");
                }
                else
                {
                    Console.WriteLine($"You took {oppsPunchDmg} DMG! You have {playerHp} left!");
                }
            }
        }
    }
}
