namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title ------------------------------------------------
            Console.WriteLine("==>> A game with a very long name <<==");
            Console.WriteLine("A game where you play game and it's very long");

            // Hero stats input -----------------------------------------------------

            Console.WriteLine("Vitality: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);

            Console.WriteLine("Strength: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);

            Console.WriteLine("Constitution: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);


            // Monster stats input --------------------------------------------------

            Console.WriteLine("Anomaly's Vitality: ");
            bool anomalyHpOk = int.TryParse(Console.ReadLine(), out int anomalyHp);

            Console.WriteLine("Strength: ");
            bool anomalyAtkOk = int.TryParse(Console.ReadLine(), out int anomalyAtk);

            Console.WriteLine("Constitution: ");
            bool anomalyDefOk = int.TryParse(Console.ReadLine(), out int anomalyDef);

            // Input validation / output --------------------------------------------

            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool anomalyStatValid = anomalyHpOk && anomalyAtkOk && anomalyDefOk;

            Console.WriteLine($"\n HERO STAT: {heroStatValid}");
            Console.WriteLine($"\n ANOMALY STAT: {anomalyStatValid}");

            bool allStatValid = heroStatValid && anomalyStatValid;

            Console.WriteLine($"[HERO]     Vit: {heroHp} // STR: {heroAtk} // CONS: {heroDef}");
            Console.WriteLine($"[ANOMALY]     Vit: {anomalyHp} // STR: {anomalyAtk} // CONS: {anomalyDef}");

            // Compound Assign & Arithmatic (+) --------------- Player used a potion.

            int potionHeal = 5;

            heroHp += potionHeal; // heroHp = heroHp + potionHeal;
            Console.WriteLine($"\nHero drank a potion, healed {potionHeal} Vit. Hero's Vatality is {heroHp}");

            // Normal Attack --------- RPG style combat ATK > DEF = damage dealt true

            int normalAttack = Math.Max(0, heroAtk - anomalyDef);
            Console.WriteLine($"Hero, via normal attack, have dealt {normalAttack}");


            // Power Attack ---------------------------------------------------------
            //           VVV    Parenthesis ensures first order
            int powerAttack = Math.Max(0, (heroAtk * 2) - anomalyDef);
            Console.WriteLine($"Hero, via power attack, have dealt {powerAttack}");

            // Random Critical Attack -----------------------------------------------

            Random rng = new Random();
            int critRoll = rng.Next(1, 101); // Wants to randomize from 100%
            bool isCrit = critRoll <= 25;    //25% Chance for critical

            int critDmg = normalAttack + Convert.ToInt32(isCrit) * normalAttack; //x2
            Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player woud deal {critDmg} DMG!!");
        }
    }
}
