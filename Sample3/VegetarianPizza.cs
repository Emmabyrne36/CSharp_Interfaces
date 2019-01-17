using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InterfacesExample.Sample3
{
    public class VegetarianPizza : IPizza
    {
        public List<string> Toppings { get; set; }
        public string Size { get; set; }

        public VegetarianPizza(string size)
        {
            Size = size;
        }

        public void Cook()
        {
             // simulate time taken to cook a pizza
            Console.WriteLine("Your vegetarian pizza is cooking...");
            Task.Run(() => Thread.Sleep(2000)).Wait();
            Console.WriteLine("Your vegetarian pizza has been cooked!");
        }

        public void Prepare(List<string> toppings)
        {
            // Add the toppings to the pizza
            Toppings = toppings;
        }
    }
}