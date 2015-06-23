using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class Duck
    {
        protected string name;
        protected Flyable fl;
        protected Quackable qua;

        public virtual void Sweem() { }
        public virtual void Show() { }
        //public Duck(string _name, Flyable _fl, Quackable _qua)
        //{
        //    name = _name;
        //    fl = _fl;
        //    qua = _qua;
        //}
    }
}
