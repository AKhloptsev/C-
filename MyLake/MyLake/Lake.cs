using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLake
{
    class Lake
    {
        List<Duck> ducksArray = new List<Duck>();
        public Lake(int n)
        {
            Random rm = new Random();
            for (int i = 0; i < n; i++)
            {
                int k = rm.Next(0, 4);
                switch (k)
                {
                    case 0:
                        ducksArray.Add(new MallardDuck());
                        break;
                        
                    case 1:
                        ducksArray.Add(new RedHatDuck());
                        break;

                    case 2:
                        ducksArray.Add(new MedicineDuck());
                        break;

                    case 3:
                        ducksArray.Add(new RubberDuck());
                        break;
                }
            }
        }

        public Lake() : this(10) { }

        public void Show()
        {
            for (int i = 0; i < ducksArray.Count; i++)
            {
                ducksArray[i].Show();
            }
        }
    }
}
