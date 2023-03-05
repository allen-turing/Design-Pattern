namespace SingletonPattern
{
	public class SingletonTypes
	{
		public void SimpleSingleton() // Non thread Safe
		{
			Instance1();
			Instance2();
		}
		public void NonThreadSafeSingleton() // Testing Non Thread Safe
		{
			Parallel.Invoke(
				() => Instance1(),
				() => Instance2()
				);
		}

		public void ThreadSafeSingleton()
		{
			Parallel.Invoke(
				() => ThreadSafeInstance1(),
				() => ThreadSafeInstance2()
				);
		}

		public void ThreadSafeDoubleLockSingleton()
		{
			Parallel.Invoke(
				() => ThreadSafeDoubleLockInstance1(),
				() => ThreadSafeDoubleLockInstance2()
				);
		}

		public void ThreadSafeLazyLoadingSingleton()
		{
			Parallel.Invoke(
				() => ThreadSafeLazyLoadingInstance1(),
				() => ThreadSafeLazyLoadingInstance2()
				);
		}

		private static void Instance1()
		{
			ChocolateFactorySingleton.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingleton.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 1");
		}
		private static void Instance2()
		{
			ChocolateFactorySingleton.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingleton.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 2");

		}

		private static void ThreadSafeInstance1()
		{
			ChocolateFactorySingletonSynchronize.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonSynchronize.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 1");
		}
		private static void ThreadSafeInstance2()
		{
			ChocolateFactorySingletonSynchronize.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonSynchronize.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 2");

		}

		private static void ThreadSafeDoubleLockInstance1()
		{
			ChocolateFactorySingletonSynchronizeDoubleLock.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonSynchronizeDoubleLock.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 1");
		}
		private static void ThreadSafeDoubleLockInstance2()
		{
			ChocolateFactorySingletonSynchronizeDoubleLock.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonSynchronizeDoubleLock.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 2");

		}

		private static void ThreadSafeLazyLoadingInstance1()
		{
			ChocolateFactorySingletonLazyLoading.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonLazyLoading.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 1");
		}
		private static void ThreadSafeLazyLoadingInstance2()
		{
			ChocolateFactorySingletonLazyLoading.ChocolateBoiler chocolateBoilerSingleton = ChocolateFactorySingletonLazyLoading.ChocolateBoiler.GetInstance();
			chocolateBoilerSingleton.Fill();
			chocolateBoilerSingleton.Boil();
			chocolateBoilerSingleton.Drain();
			Console.WriteLine("From Instance 2");

		}
	}
}
