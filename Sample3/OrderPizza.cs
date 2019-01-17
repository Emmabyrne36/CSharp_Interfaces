using System;
using System.Collections.Generic;

namespace InterfacesExample.Sample3
{
    public class OrderPizza
    {
        public static IPizza Order(string pizza, string size)
        {
            IPizza preparedPizza;

            switch (pizza.GetType().ToString())
            {
                case "Pepperoni":
                    preparedPizza = new PepperoniPizza(size);
                    break;
                case "Vegetarian":
                    preparedPizza = new VegetarianPizza(size);
                    break;
                default:
                    preparedPizza = new MargheritaPizza(size);
                    break;
            }

            preparedPizza.Prepare(GetIngredients(pizza));
            preparedPizza.Cook();

            return preparedPizza;
        }

        public static void ReviewOrder(IPizza pizza)
        {
            Console.WriteLine($"The pizza you ordered was a {pizza.Size} with ");
            pizza.Toppings.ForEach(t => PrintToppings(pizza, t));
        }

        private static List<string> GetIngredients(string pizzaName)
        {
            List<string> ingredients = new List<string> { "Tomato sauce", "Cheese" };
            switch (pizzaName)
            {
                case "Pepperoni":
                    ingredients.Add("Pepperoni");
                    break;
                case "Vegetarian":
                    ingredients.AddRange();
                    break;
                case "Tandori Chicken":
                    ingredients.AddRange(new List<string> { "Pepperoni", "Smoked bacon", "Tomatoes", "Mixed peppers" });
                    break;
                default:
                    break;
            }

            return ingredients;
        }

        private static void PrintToppings(IPizza pizza, string t)
        {
            System.Console.Write(t);
            if (!pizza.Toppings[pizza.Toppings.Count - 1].Equals(t))
                System.Console.Write(", ");
        }
    }
}