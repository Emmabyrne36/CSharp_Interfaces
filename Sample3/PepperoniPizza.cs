using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InterfacesExample.Sample3
{
    public class PepperoniPizza : IPizza
    {
        public List<string> Toppings { get; set; }
        public string Size { get; set; }

        public PepperoniPizza(string size)
        {
            Size = size;
        }

        public void Cook()
        {
            // simulate time taken to cook a pizza
            System.Console.WriteLine("Your pepperoni pizza is cooking...");
            Task.Run(() => Thread.Sleep(2000)).Wait();
            System.Console.WriteLine("Your pepperoni pizza has been cooked!");
        }

        public void Prepare(List<string> toppings)
        {
            // Add the toppings to the pizza
            Toppings = toppings;
        }

        public override string ToString()
        {
            return "Pepperoni";
        }
    }
}