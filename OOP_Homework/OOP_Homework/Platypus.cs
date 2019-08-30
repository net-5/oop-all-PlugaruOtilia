using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Platypus : Mammals, IWalk, Iswim
    {
        private int speed;

        public Platypus(string name) : base(name)
        {

        }

       

        public void Walk()
        {
            if (speed < 10)
            {
                Console.WriteLine($"I'm {Name} and i walk so slow.");
            }
            if (speed >= 10 && speed <= 20)
            {
                Console.WriteLine($"I'm {Name} and i walk with a medium speed.");
            }
            else
            {
                Console.WriteLine("I'm a platypus,i am not a rocket.");
            }
        }

        public void Swim()
        {
            
        }
    }
}