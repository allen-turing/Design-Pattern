using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaStoreNaive
{
    public class PizzaStoreNaiveProgram
    {
        public PizzaStoreNaiveProgram()
        {
            PizzaStore pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza("Cheese");
            pizzaStore.OrderPizza("Sabudana");
        }
        

    }
}
