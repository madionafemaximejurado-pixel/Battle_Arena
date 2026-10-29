using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors.Characters
{
    public class Jack : Warrior
    {
        public int SlashDamage { get; private set; }

        public Jack(int health, int attackPower, int speed, int slashDamage, TeamType teamType)
            : base("Jack", health, attackPower, speed, WarriorType.Fighter, teamType)
        {
            SlashDamage = slashDamage;
            attackPower += SlashDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Sugod", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Susugurin kita {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Aray ko po!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: Buhay pa ko {target.Name}");
        }
    }
}