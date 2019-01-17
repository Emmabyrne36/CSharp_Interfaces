using System;

namespace InterfacesExample.Sample2
{
    public class Television : IElectronicDevice
    {
        // Because we implemented the 
        // ElectronicDevice interface any
        // other device we create will know
        // exactly how to interface with it.
        public int Volume { get; set; } = 0;
        public void Off()
        {
            Console.WriteLine("TV off");
        }

        public void On()
        {
            Console.WriteLine("TV on");
        }

        public void VolumeDown()
        {
            if (Volume != 0)
                Volume--;
            Console.WriteLine($"The volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100)
                Volume++;
            Console.WriteLine($"The volumne is at {Volume}");
        }
    }
}