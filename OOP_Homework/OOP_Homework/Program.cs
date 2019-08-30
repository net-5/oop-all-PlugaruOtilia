using System;

namespace OOP_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            WildDuck newDuck = new WildDuck("Rata");
            newDuck.Fly(4);
           
           
            Platypus platypus = new Platypus("Plat");
            platypus.Walk(10);

            Ostrich ostrich = new Ostrich("Strut");
            ostrich.Walk(15);

            Bat bat = new Bat("Liliac");
            bat.Fly(30);

        }
    }
}
