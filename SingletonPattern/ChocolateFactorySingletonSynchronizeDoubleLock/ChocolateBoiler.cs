namespace SingletonPattern.ChocolateFactorySingletonSynchronizeDoubleLock
{
	public class ChocolateBoiler
	{
		private bool _empty;
		private bool _boiled;
		private static readonly object _instanceLock = new object();
		private static ChocolateBoiler? _uniqueInstance;

		private ChocolateBoiler()
		{
			_empty = true;
			_boiled = false;
			Console.WriteLine("Initialized the Singleton Instance");

		}

		public static ChocolateBoiler GetInstance()
		{
			if (_uniqueInstance == null)
			{
				Console.WriteLine("Singleton Instance is null");
				lock (_instanceLock)
				{
					Console.WriteLine("Applying Instance Lock");
					if (_uniqueInstance == null)
					{
						Console.WriteLine("Singleton Instance is null so creating an instance");
						_uniqueInstance = new ChocolateBoiler();
					}
				}
			}
			Console.WriteLine("Got Singleton Instance");
			return _uniqueInstance;
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
