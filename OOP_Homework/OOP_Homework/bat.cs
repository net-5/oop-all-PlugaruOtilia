using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
   public class Bat: Mammals, IFly
    {
        

        public Bat(string name) : base(name)
        {

        }

        public void Fly(int speed)
        {
            if (speed < 15)
            {
                Console.WriteLine($"I'm {Name}, fly slowly");
            }
            else
            {
                Console.WriteLine($"I'm {Name} and flying very fast");
            }
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
    }

