using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class Quack : Quackable
    {
        public override void quack()
        {
            Console.Write("QUACK!\t");
        }
    }
}
