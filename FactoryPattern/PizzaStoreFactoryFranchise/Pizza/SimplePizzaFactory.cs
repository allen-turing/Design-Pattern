namespace FactoryPattern.PizzaStoreFactoryFranchise.Pizza
{
	public class SimplePizzaFactory
	{
		public Pizza CreatePizza(string type)
		{
			Pizza? pizza = null;
			Console.WriteLine("Inside the Pizza Factory!");
			if (type.Equals("Cheese"))
				pizza = new CheesePizza();
			else if (type.Equals("Greek"))
				pizza = new GreekPizza();
			else if (type.Equals("Pepperoni"))
				pizza = new PepperoniPizza();
			else if (type.Equals("Veggie"))
				pizza = new VeggiePizza();
			else if (type.Equals("Clam"))
				pizza = new ClamPizza();
			else
			{
				pizza = new NotAvailablePizza();
				pizza.CanNotPrepare();
				return pizza;
			}
			return pizza;
		}
	}
}
