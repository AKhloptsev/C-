using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class MedicineDuck : Duck
    {
        public MedicineDuck()
        {
            name = "MedicineDuck";
            fl = new NoFly();
            qua = new NoQuack();
        }

        public override void Sweem()
        {
            Console.Write(" I can sweem!\t");
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
