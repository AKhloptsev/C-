using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class Fly : Flyable
    {
        public override void fly()
        {
            Console.Write("I'm fly!\t");
        }
    }
}
