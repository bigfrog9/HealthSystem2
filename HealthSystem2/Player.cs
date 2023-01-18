using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystem2
{
    internal class Player
    {
        private int health = 100;
        private int lives = 3;

        public void GetHealth(int hp)
        {
            health += hp;

            if (health > 100) health = 100;

        }

        public void TakeDamage(int hp)
        {
            health -= hp;

            if (health < 0) health = 0;

            if (health == 0)
            {
                lives--;

                health = 100;
            }

            if (lives == 0) health = 0;
        }

        public void ShowHud()
        {

            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine("--------");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine();
        }

    }
}
