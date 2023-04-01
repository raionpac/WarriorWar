using System;
using System.Threading;
using WarriorWar.Enum;

namespace WarriorWar
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Ken", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Leo", Faction.BadGuy);

            while ((goodGuy.IsAlive && badGuy.IsAlive))
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
                Thread.Sleep(10);

            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (keyInfo.Key != ConsoleKey.Enter)
            { keyInfo = Console.ReadKey(); }
        }
    }
}
