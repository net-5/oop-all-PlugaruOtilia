using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    public class Platypus : Mammals, IWalk, Iswim
    {
        

        public Platypus(string name) : base(name)
        {

        }

       

        public void Walk(int speed)
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

        public void Swim(int speed)
        {
            
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}