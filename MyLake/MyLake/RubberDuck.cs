using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            name = "Rubber Duck";
            fl = new NoFly();
            qua = new Quack();
        }

        public override void Sweem()
        {
            Console.Write("I can sweem!\t");
        }

        public override void Show()
        {
            Console.Write("I am {0}\t", name);
            Sweem();
            fl.fly();
            qua.quack();
            Console.WriteLine();
        }
    }
}
