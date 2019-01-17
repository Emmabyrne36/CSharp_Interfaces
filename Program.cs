using System;
using InterfacesExample.Sample1;
using InterfacesExample.Sample2;
using InterfacesExample.Sample3;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for sample 1 adapted from StackOverflow answer at: https://stackoverflow.com/questions/6802573/c-sharp-interfaces-whats-the-point
            Sample1();

            // Code for sample 2 obtained from Interfaces tutorial found at: http://www.newthinktank.com/2017/02/c-tutorial-10/
            Sample2();

            Sample3();
        }

        private static void Sample1()
        {
            SpawnCreature.Spawn("Orc");
            SpawnCreature.Spawn("Troll");
        }

        private static void Sample2()
        {
            // We are now modeling the act of
            // picking up a remote, aiming it
            // at the TV, clicking the power
            // button and then watching as
            // the TV turns on and off

            // Pick up the TV remote
            IElectronicDevice TV = TvRemote.GetDevice();

            // Create the power button
            PowerButton powBut = new PowerButton(TV);

            // Turn the TV on and off with each 
            // press
            powBut.Execute();
            TV.VolumeUp();
            powBut.Undo();
        }

        private static void Sample3()
        {
            IPizza pizza = OrderPizza.Order("Vegetarian", "Large");
            OrderPizza.ReviewOrder(pizza);
        }
    }
}
