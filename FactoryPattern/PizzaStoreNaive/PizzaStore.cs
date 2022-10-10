namespace FactoryPattern.PizzaStoreNaive
{
    public class PizzaStore
    {
        public Pizza.Pizza OrderPizaa()
        {
            Pizza.Pizza pizza = new Pizza.Pizza();

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        public Pizza.Pizza OrderPizza(string type)
        {
            Pizza.Pizza pizza;

            if (type.Equals("Cheese"))
                pizza = new Pizza.CheesePizza();
            else if (type.Equals("Greek"))
                pizza = new Pizza.GreekPizza();
            else if (type.Equals("Pepperoni"))
                pizza = new Pizza.PepperoniPizza();
            else if (type.Equals("Veggie"))
                pizza = new Pizza.VeggiePizza();
            else if (type.Equals("Clam"))
                pizza = new Pizza.ClamPizza();
            else
            {
                pizza = new Pizza.NotAvailablePizza();
                pizza.CanNotPrepare();
                return pizza;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
    