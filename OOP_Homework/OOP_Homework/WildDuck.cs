using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    class WildDuck : Birds, Iswim, IFly, IWalk

    {
        private int speed;

        public WildDuck(string name) : base(name)
        {

        }
        public void Fly()
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name},and i fly slowly");
            }
            else
            {
                Console.WriteLine($"I'm {Name} and and i fly like a Boeing");
            }
        }

        public void Swim()
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name},and i am not a goosd swimmer");
            }
            else
            {
                Console.WriteLine($"I'm {Name} and and i am a good swimmer");
            }
        }

        public void Walk()
        {
            if (speed < 5)
            {
                Console.WriteLine($"I'm {Name},and i walk slowly");
            }
            else
            {
                Console.WriteLine($"I'm {Name} and and i walk very fast");
            }
        }
    }
}
