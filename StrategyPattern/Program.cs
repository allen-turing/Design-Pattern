// See https://aka.ms/new-console-template for more information

using StrategyPattern.Ducks;
using StrategyPattern.Ducks.Quack;
using StrategyPattern.Ducks.Quack.Fly;

Console.WriteLine("-------------STRATEGY PATTERN----------");
Console.WriteLine("--------------For Model Duck-----------");

Duck model = new ModelDuck();
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();

Console.WriteLine("--------------For Mallard Duck-----------");

Duck mallardDuck = new MallardDuck(new FlyRocketPowered(),new Quack());
mallardDuck.PerformFly();
mallardDuck.SetFlyBehavior(new FlyNoWay());
mallardDuck.PerformFly();


Duck mallard = new MallardDuck(new FlyNoWay(),new Quack());
mallard.PerformQuack();
mallard.PerformFly();