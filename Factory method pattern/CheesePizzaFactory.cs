using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    // ConcreteFactory (+FactoryMethod() : ProductBase)
    public class CheesePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new CheesePizza(); // ConcreteProduct (CheesePizza) created here
        }
    }
}
 