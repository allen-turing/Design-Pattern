using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaStoreFactory.Pizza
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            _name = "Cheese";
        }
    }
}
