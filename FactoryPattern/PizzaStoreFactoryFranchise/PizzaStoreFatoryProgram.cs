using FactoryPattern.PizzaStoreFactoryFranchise.Pizza;

namespace FactoryPattern.PizzaStoreFactoryFranchise
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
