using FactoryPattern.PizzaStoreFactory.Pizza;

namespace FactoryPattern.PizzaStoreFactory
{
	public class PizzaStoreFatoryProgram
	{
		public PizzaStoreFatoryProgram()
		{
			PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
			pizzaStore.OrderPizaa("Pepperoni");
		}
	}
}
