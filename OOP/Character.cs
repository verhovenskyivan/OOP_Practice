using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Character
    {
        public int Health { get; private     set; } = 100;

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
    }
}
