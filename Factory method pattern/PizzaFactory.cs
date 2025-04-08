using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    public abstract class PizzaFactory
    {
        // FactoryBase (+FactoryMethod() : ProductBase) (Abstract Factory)
        public abstract Pizza CreatePizza(); // Factory Method that returns a ProductBase
    }
}
