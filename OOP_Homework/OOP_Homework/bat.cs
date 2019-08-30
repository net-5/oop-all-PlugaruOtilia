using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class Bat: Mammals, IFly
    {
        private int speed;

        public Bat(string name) : base(name)
        {

        }
public void Fly()
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
    }
}
