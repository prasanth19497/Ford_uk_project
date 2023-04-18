using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewProject
{
    abstract class Character
    {
        public abstract void Move();
        public abstract void Attack();
        public abstract void PinFall();

    }

    class Player : Character
    {
        public override void Move()
        {
            Console.WriteLine("Move close to the enemy");
        }

        public override void Attack()
        {
            Console.WriteLine("Attack the enemy");
        }

        public override void PinFall()
        {

            Console.WriteLine("Do the pinfall and win the game");
        }
    }

    class Enemy : Character
    {

        public override void Move()
        {
            Console.WriteLine("Move close to the player");
        }

        public override void Attack()
        {
            Console.WriteLine("Attack the  player");
        }

        public override void PinFall()
        {
            Console.WriteLine("Try breaking the player pinfall and win");
                   
        }

        public static void Main(String[] args)
        {
            Player player = new Player();
            player.Move();
            player.Attack();
            player.PinFall();
            Enemy enemy = new Enemy();
            enemy.Move();
            enemy.Attack();
            enemy.PinFall();    
        }
    }
}
