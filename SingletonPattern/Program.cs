// See https://aka.ms/new-console-template for more information

using SingletonPattern;

Console.WriteLine("*******Chocolate Boiler Without Singleton*******");
SingletonPattern.CholcolateFactory.ChocolateBoiler chocolateBoiler = new SingletonPattern.CholcolateFactory.ChocolateBoiler();
chocolateBoiler.Fill();
chocolateBoiler.Boil();
chocolateBoiler.Drain();
Console.WriteLine("----------------------\n");


Console.WriteLine("*******Chocolate Boiler Singleton*******");
SingletonTypes singletonTypes = new SingletonTypes();
// Comment out SimpleSingleton() to see non thread safety
singletonTypes.SimpleSingleton();
//singletonTypes.NonThreadSafeSingleton();
Console.WriteLine("----------------------\n");


Console.WriteLine("*******Chocolate Boiler Thread Safe Singleton*******");
singletonTypes.ThreadSafeSingleton();
Console.WriteLine("----------------------\n");


Console.WriteLine("*******Chocolate Boiler Thread Safe Double Lock Singleton*******");
singletonTypes.ThreadSafeDoubleLockSingleton();
Console.WriteLine("----------------------\n");


Console.WriteLine("*******Chocolate Boiler Thread Safe Lazy Loading Singleton*******");
singletonTypes.ThreadSafeLazyLoadingSingleton();
Console.WriteLine("----------------------\n");



