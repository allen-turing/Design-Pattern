using FactoryPattern.PizzaStoreFactory.Pizza;

namespace FactoryPattern.PizzaStoreFactory
{
	public class PizzaStore
	{
		SimplePizzaFactory _simplePizzaFactory;

		public PizzaStore(SimplePizzaFactory simplePizzaFactory)
		{
			_simplePizzaFactory = simplePizzaFactory;
		}
		public Pizza.Pizza OrderPizaa(string type)
		{
			Pizza.Pizza? pizza = null;
			pizza = _simplePizzaFactory.CreatePizza(type);

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();

			return pizza;
		}


	}
}
