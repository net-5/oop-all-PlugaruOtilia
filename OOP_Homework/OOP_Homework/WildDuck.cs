using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework
{
    public class WildDuck : Birds, Iswim, IFly, IWalk
          

    {

        
        public WildDuck(string name) : base(name)
        {

        }
        


        public void Fly(int speed)
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

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim(int speed)
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

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Walk(int speed)
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

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
