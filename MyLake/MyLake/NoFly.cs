using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class NoFly : Flyable
    {
        public override void fly()
        {
            Console.Write("I'm don't fly=(\t");
        }
    }
}
