namespace SingletonPattern.ChocolateFactorySingletonLazyLoading
{
	public class ChocolateBoiler
	{
		private bool _empty;
		private bool _boiled;
		private static readonly Lazy<ChocolateBoiler> _instanceLock = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());

		private ChocolateBoiler()
		{
			_empty = true;
			_boiled = false;
			Console.WriteLine("Initialized the Singleton Instance");

		}

		public static ChocolateBoiler GetInstance()
		{
			Console.WriteLine("Got Singleton Instance");
			return _instanceLock.Value;
		}
		public void Fill()
		{
			if (IsEmpty())
			{
				_empty = false;
				_boiled = false;
				Console.WriteLine("Fill the Boiler with Milk/Choclolate mixture");
			}
		}

		public void Drain()
		{
			if (!IsEmpty() && IsBoiled())
			{
				_empty = true;
				Console.WriteLine("Drain the boiled milk and chololate");
			}
		}
		public void Boil()
		{
			if (!IsEmpty() && !IsBoiled())
			{
				_boiled = true;
				Console.WriteLine("Bring the content to a boil");
			}
		}

		public bool IsEmpty()
		{
			return _empty;
		}
		public bool IsBoiled()
		{
			return _boiled;
		}
	}
}
