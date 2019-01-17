using System;

namespace InterfacesExample.Sample1
{
    public class Troll : ICreature
    {
        public int StartDistance { get; set; }

        public Troll()
        {
            StartDistance = 0;
        }
        public void Shout()
        {
            Console.WriteLine("I am a Troll!");
        }

        public void Walk()
        {
            StartDistance++;
        }
    }

    public class Orc : ICreature
    {
        public int StartDistance { get; set; }

        public Orc()
        {
            StartDistance = 0;
        }

        public void Shout()
        {
            Console.WriteLine("I am an Orc!");
        }

        public void Walk()
        {
            StartDistance++;
        }
    }
}