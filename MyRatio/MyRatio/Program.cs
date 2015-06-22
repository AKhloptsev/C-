using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRatio
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём два экземпляра класса Ratio и сравниваем их
            Ratio instance1 = new Ratio(1, 4);
            Ratio instance2 = new Ratio(1, 2);
            if (instance1 == instance2)
                Console.WriteLine("Равны");
            else
                Console.WriteLine("Не равны");
            // явное преобразование (получаем длину вектора)
            double length = (double)instance1;
            Console.WriteLine("length = " + length.ToString());
        }
    }
}
