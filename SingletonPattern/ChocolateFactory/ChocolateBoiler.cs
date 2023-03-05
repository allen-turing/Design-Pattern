namespace SingletonPattern.CholcolateFactory
{
	public class ChocolateBoiler
	{
		private bool _empty;
		private bool _boiled;

		public ChocolateBoiler()
		{
			_empty = true;
			_boiled = false;
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
