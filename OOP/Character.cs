using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class Character
    {
      public int Health = 100;

      public void Hit(int damage)
        {
            Health -= damage;
        }
    }
}
