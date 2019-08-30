using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Ostrich:Birds, IWalk
    {
        private int speed;

        public Ostrich(string name) : base(name)
        {

        }

        public void Walk()
        {
            if (speed >= 15)
            {
                Console.WriteLine("$I'm {Name} and i walk slow");
            }
            else
            {
                Console.WriteLine("$I'm {Name} and i run");
            }
            }
        }
    }

