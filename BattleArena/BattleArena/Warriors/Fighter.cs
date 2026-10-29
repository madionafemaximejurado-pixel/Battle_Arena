using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Fighter : Warrior
    {
        public int SwordDamage;
        public Fighter(string name, int health, int attackPower, int swordDamage)
            : base(name, health, attackPower)
        {
            SwordDamage = swordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + SwordDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t->{Name}: bleed damage {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: ugh ugh! ");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: revive! ");
            Thread.Sleep(1000);

            Console.WriteLine($"\t------- {target.Name} ------");
            Console.WriteLine($"\t    * DamageTaken: {totalDamage}");
            Console.WriteLine($"\t    * Health Remaining: {target.Health}");
        }
    }
}
