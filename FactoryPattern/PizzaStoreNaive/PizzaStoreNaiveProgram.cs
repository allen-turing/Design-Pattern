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
