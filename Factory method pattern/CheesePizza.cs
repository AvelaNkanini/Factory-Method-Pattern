using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    // ConcreteProduct (Cheese Pizza)
    public class CheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza ");
        }
    }
}
