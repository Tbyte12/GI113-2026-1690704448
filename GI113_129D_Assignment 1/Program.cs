namespace GI113_129D_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string PlayerStat = "MMP\"\"\"\"\"\"\"MM                              dP  \r\nM' .mmmm  MM                              88  \r\nM         `M .d8888b. .d8888b. 88d888b. d8888P\r\nM  MMMMM  MM 88'  `88 88ooood8 88'  `88   88  \r\nM  MMMMM  MM 88.  .88 88.  ... 88    88   88  \r\nM  MMMMM  MM `8888P88 `88888P' dP    dP   dP  \r\nMMMMMMMMMMMM      .88                         \r\n              d8888P                          \r\nMP\"\"\"\"\"\"`MM   dP              dP              \r\nM  mmmmm..M   88              88              \r\nM.      `YM d8888P .d8888b. d8888P            \r\nMMMMMMM.  M   88   88'  `88   88              \r\nM. .MMM'  M   88   88.  .88   88              \r\nMb.     .dM   dP   `88888P8   dP              \r\nMMMMMMMMMMM                                   ";
            string freedomFighter = "Thessaloniki";
            var fighterRank = "Lieutenant";
            var fighterLevel = 57;
            int killTotal = 140035;
            int robotKillTotal = 10326;
            int incapTotal = 532;
            double hitAccuracy = 94.752349;
            float killPerDeath = 24.22f;
            int friendlyKill = 423;
            double friendlyFireTotal = 40640;
            double missionSuccess = 64.2;
            int missionFailure = 564;

            //-------------------------------------------------------

            Console.WriteLine(PlayerStat);
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine($"Agent:                      {freedomFighter}");
            Console.WriteLine($"Ranking:                    {fighterRank}");
            Console.WriteLine($"Experience Level:           {fighterLevel}");

            Console.WriteLine("----------------------------------------------------");

            double killTotalLeniant = killTotal;
            Console.WriteLine($"Enemy Incapacitated:        {killTotal}");
            Console.WriteLine($"Machine Destroyed:          {robotKillTotal}");
            Console.WriteLine($"Total Incapacitation:       {incapTotal}");
            
            float hitAccuracyRounded = (int)hitAccuracy;
            Console.WriteLine($"Fired Round Accuracy:       {hitAccuracyRounded}");

            float killPerDeathRounded = (int)killPerDeath;
            Console.WriteLine($"Kill Per Incapacitation:    {killPerDeathRounded}");
            Console.WriteLine($"Operational Success:        {missionSuccess}");
            Console.WriteLine($"Operational Failure:        {missionFailure}");
           
            Console.WriteLine($"\n============== Operational Misconducts =============");
            Console.WriteLine($"\nCount of Ally Manslaughter: {friendlyKill} Charges");
            Console.WriteLine($"Count of Ally Assault:      {friendlyFireTotal} Charges");
            Console.WriteLine("\n================= Agent Will Be Charge ACCORDINGLY =");

            Console.WriteLine("\n\n. ....  .    .  ..         . .      ..=+:.....        \r\n  .-:.....                       ....:#*...*-..   .   \r\n  ..+#:....   .   ...             ...#@=..+@-..       \r\n  ...*@++:..   .  ...      .. .   ..*@+..*@#:... .  . \r\n  ...:@@%%=..  .  ... .       .....*@#:.+@%-.=:.  .   \r\n  ....+@@@%=:.... ...         ...-%@%-.+@%-.=*:...    \r\n.    .-@@@@@#+:.....       ....:+@@%=-#@%-.-%+....    \r\n .  ...#@@@@@%+*...    .......=%@@@**@@#:.=%*:....  . \r\n    ...*@@@@@@@%=.... .....:=%@@@@@@@@*::*@*:....     \r\n    ...*@@@@@@@@%-... ...:+@@@@@@@@@@+-#@@+.:+....  . \r\n     .-@@@@@@@@@@@*.. ..=@@@@@@@@@@@@@@@%-.=%-...     \r\n    ..-@@@@@@@@@@@@#:..=@@@@@@@@@@@@@@@+:=#*:...    . \r\n  . ...=@@@@@@@@@@@@#:-#@@@@@@@@@@@@@@@%@#-... ..  .  \r\n  . ....+@@@@@@@@@@@@*=@@@@@@@@@@@@@@@@%=:=:..   .. . \r\n .. .....#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#**:...     .  \r\n     ....-@@@@@@@@@@@@@@@@@@@@@@@@@@@@@#-.......      \r\n      ....#@@@@@@@@@@@@@@@@@@@@@@@@@@@@#:..        .  \r\n     .  ..+@@@@@@@@@@@@@@@@@@@@@@@@@@@#:...           \r\n        ..-@@@@@@@@@@@@@@@@@@@@@@@@@@@=...   .. .     \r\n. .  .....=@@@@@@@@@@@@@@@@@@@@@@@@@@#:...            \r\n     ...:#@@@@@@@@@@@@@@@@@@@@@@@@@%=...              \r\n    ...:@@@@@@@@@@@@@@@@@@@@@@@@@#+:...               \r\n . ....#@@@@@@@@@@@@@@@@@@@@@@@@#-....                \r\n  ....*@@@@@@@@@@@@@@@@@@@@@@@@@@%-...                \r\n  ...:@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=...           .   \r\n  ...+@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=..  . ..   .     \r\n  ...#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@=..              \r\n  ..:@@@@@@@@@@#:...:-:-*@@@@@@@@@@@@@=....      .    \r\n  ...%@@@@@@@@*:........=@@%@@@@#-.:#@@=...           \r\n  ...=@@@@@@@*........::+@*-#%%@%=..=@@@=...      . . \r\n   ...+@@@@@%:..-%@@%%###*=*@%+*@+...*@@@=....  .     \r\n    ...=@@@@#.:*@#**....-#%-..*#-.....#@@@=....       \r\n    .....=@@#.:*=*#=.=%@+:..-#+.......+@@@@-..        \r\n       ..=@@%:.:-=:.=@#++.=%@+..     ..#@@@@-.        \r\n        .:%@%-.....:*@*=+:=@*++...  ...+@@@@#:....    \r\n      .....==.  .  .:**+:.-#*=-..... ..=%@@@@#:...  . \r\n .       ..... ..  ........-=-...    ..:#@@@@@*:..    \r\n                .   .                ...=%@@@@@+..    \r\n   ...                  .            ....+%@@@@@+.... \r\n           .  .    .     .     . .   . ....=%@@@@-... \r\n                             .        .  ...:-%%@%:...\r\n .      ..  .    .                       .   ..:.++...\r\n   .               .        .                .........");

        }
    }
}
