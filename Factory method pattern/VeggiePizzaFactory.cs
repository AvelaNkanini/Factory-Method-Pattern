using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    public class VeggiePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza()
        {
            return new VeggiePizza();
        }
    }
}
