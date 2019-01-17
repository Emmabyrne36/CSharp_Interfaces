using System.Collections.Generic;

namespace InterfacesExample.Sample3
{
    public interface IPizza
    {
        List<string> Toppings { get; set; }
        string Size { get; set; }

        void Prepare(List<string> toppings);
        void Cook();
    }
}