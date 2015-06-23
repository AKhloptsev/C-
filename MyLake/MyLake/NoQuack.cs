using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class NoQuack : Quackable
    {
        public override void quack()
        {
            Console.Write("I'm don't quack=(\t");
        }
    }
}
