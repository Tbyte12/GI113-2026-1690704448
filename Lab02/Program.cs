/*
 * Student ID : 169704448
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System.Diagnostics;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)  //Week 2: Part A
        {
            string bossName = "Kirin";
            char rank = 's';
            int level = 10;
            int maxHP = 240;
            int currentHP = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INTIAL ====="); //Part A Boss
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHP}/{maxHP}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine("");
            Console.WriteLine($"HP Percent: {currentHP * 100 / maxHP}%");
            Console.WriteLine("");

            Console.WriteLine($"Kirin takes 60 damage!");
            currentHP = currentHP - 60;
            Console.WriteLine("");

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHP}");
            int hpPercent = currentHP * 100 / maxHP;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //-----------------------------------------------------------------Introductory

            Console.WriteLine("===== Part B ====="); //Week 2: Part B
            Console.WriteLine("");

            //------------------------------------------------------------------------------

            string bossName1 = "Externite"; //Enemy 1 
            char rank1 = 'B';
            int level1 = 5;
            int maxHP1 = 100;
            float attackPower1 = 20.5f;
            double critMultiplier1 = 1.25;
            bool isBoss1 = false;

            Console.WriteLine("Enemy 1");
            Console.WriteLine($"Name: {bossName1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"Level: {level1}");
            Console.WriteLine($"HP: {maxHP1}");
            Console.WriteLine($"Attack Power: {attackPower1}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier1}");
            Console.WriteLine($"Is Boss: {isBoss1}");
            Console.WriteLine("");

            Console.WriteLine("Enemy No.1");
            Console.WriteLine("");

            //------------------------------------------------------------------------------

            string bossName2 = "Luxon"; //Enemy 2
            char rank2 = 'B';
            int level2 = 6;
            int maxHP2 = 125;
            float attackPower2 = 15.5f;
            double critMultiplier2 = 1.00;
            bool isBoss2 = false;

            Console.WriteLine("Enemy 2");
            Console.WriteLine($"Name: {bossName2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"Level: {level2}");
            Console.WriteLine($"HP: {maxHP2}");
            Console.WriteLine($"Attack Power: {attackPower2}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier2}");
            Console.WriteLine($"Is Boss: {isBoss2}");
            Console.WriteLine("");

            //------------------------------------------------------------------------------

            string bossName3 = "Ryuzaki"; //Enemy 3
            char rank3 = 'B';
            int level3 = 8;
            int maxHP3 = 75;
            float attackPower3 = 25.67f;
            double critMultiplier3 = 2.25;
            bool isBoss3 = false;

            Console.WriteLine("Enemy 3");
            Console.WriteLine($"Name: {bossName3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"Level: {level3}");
            Console.WriteLine($"HP: {maxHP3}");
            Console.WriteLine($"Attack Power: {attackPower3}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier3}");
            Console.WriteLine($"Is Boss: {isBoss3}");
            Console.WriteLine("");

            //------------------------------------------------------------------------------

            string bossName4 = "Coffee"; //Enemy 3
            string rank4 = 'B+';
            int level4 = 7;
            int maxHP4 = 110;
            float attackPower4 = 15.5f;
            double critMultiplier4 = 1.75;
            bool isBoss4 = false;

            Console.WriteLine("Enemy 4");
            Console.WriteLine($"Name: {bossName4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"Level: {level4}");
            Console.WriteLine($"HP: {maxHP4}");
            Console.WriteLine($"Attack Power: {attackPower4}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier4}");
            Console.WriteLine($"Is Boss: {isBoss4}");
            Console.WriteLine("");

            //------------------------------------------------------------------------------
        }
    }
}
