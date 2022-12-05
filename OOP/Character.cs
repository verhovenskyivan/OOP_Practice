using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Character
    {
        public static int speed = 10;
        public int Health { get; private     set; } = 100;

        public string Race { get; private set; }

        public int Armor { get; private set; }

        public Character(string race)
        {
            Race = race;
            Armor = 30;
        }

        public Character(string race, int armor = 30)
        {
            Race = race;
            Armor = armor;
        }
        public int GetHealth()
        {
            return Health;
        }
        public void SetHealth(int value)
        {
            Health = value;
        }
      public void Hit(int damage)
        {
            if(damage > Health)
               damage = Health;

            Health -= damage;
        }
        public int PrintSpeed()
        {
            return speed;
        }
        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
