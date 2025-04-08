using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // ConcreteFactory used to create a ConcreteProduct
            //-------------------------------------------------
            //Create a Cheese Pizza using the Factory
            PizzaFactory factory1 = new CheesePizzaFactory();  // ConcreteFactory
            Pizza cheesePizza = factory1.CreatePizza(); // ConcreteProduct
            cheesePizza.Prepare();  // Using the ProductBase (Pizza)

            //Create a Pepperoni Pizza using the Factory
            PizzaFactory factory2 = new PepperoniPizzaFactory();
            Pizza pepperoniPizza = factory2.CreatePizza();
            pepperoniPizza.Prepare();

            //Create a Veggie Pizza using the Factory
            PizzaFactory factory3 = new VeggiePizzaFactory();
            Pizza veggiePizza = factory3.CreatePizza();
            veggiePizza.Prepare();
        }
    }
}
