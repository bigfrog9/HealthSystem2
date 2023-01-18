using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.ShowHud();

            player.TakeDamage(30);

            player.ShowHud();

            player.GetHealth(5);

            player.ShowHud();

            player.TakeDamage(120);

            player.ShowHud();

            Console.ReadKey(true);
        }
    }
}
