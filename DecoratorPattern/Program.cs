// See https://aka.ms/new-console-template for more information

using DecoratorPattern.StarBuzzCoffee.Beverage;
using DecoratorPattern.StarBuzzCoffee.Components;
using DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

Console.WriteLine("-------------Decorator Pattern-------------");

Beverage beverage = new Espresso();
Console.WriteLine(beverage.GetDescription()+" Rs: "+beverage.Cost());

Beverage beverage2 = new DarkRost();
beverage2 = new Mocha(beverage2);
beverage2 = new Soy(beverage2);
beverage2 = new Whip(beverage2);
beverage2 = new Milk(beverage2);


Console.WriteLine(beverage2.GetDescription()+" Rs: "+beverage2.Cost());
