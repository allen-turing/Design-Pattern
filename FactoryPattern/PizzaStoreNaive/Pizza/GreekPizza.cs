using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaStoreNaive.Pizza
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            _name = "Greek";
        }
    }
}
