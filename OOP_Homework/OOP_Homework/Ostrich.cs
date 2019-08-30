using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    public class Ostrich:Birds, IWalk
    {
        

        public Ostrich(string name) : base(name)
        {

        }

        public void Walk(int speed)
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

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
    }

