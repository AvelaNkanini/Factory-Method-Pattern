using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method_pattern
{
    class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Veggie Pizza");
        }
    }
}
