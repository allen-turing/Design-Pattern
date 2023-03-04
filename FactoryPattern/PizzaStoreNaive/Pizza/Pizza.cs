namespace FactoryPattern.PizzaStoreNaive.Pizza
{
	public class Pizza
	{
		public string? _name;
		public void Prepare()
		{
			Console.WriteLine($"Preparing Your {_name} Pizza");
		}
		public void Bake()
		{
			Console.WriteLine($"Baking Your {_name} Pizza");
		}
		public void Cut()
		{
			Console.WriteLine($"Cutting Your {_name} Pizza");
		}
		public void Box()
		{
			Console.WriteLine($"Packing Your {_name} Pizza in a Box");
		}
		public void CanNotPrepare()
		{
			Console.WriteLine($"Can not prepare Your {_name} Pizza");
		}
	}
}
