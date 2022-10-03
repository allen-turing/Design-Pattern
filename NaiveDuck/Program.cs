// See https://aka.ms/new-console-template for more information

using NaiveDuck;

Console.WriteLine("----------START----------------");
Duck duck = new RedheadDuck();
duck.Quack();
duck.Display();
duck.Fly();
Console.WriteLine("-----------END-----------------");


Console.WriteLine("RedheadDuck----------START----------------");
RedheadDuck redheadDuck = new RedheadDuck();
redheadDuck.Quack();
redheadDuck.Display();
redheadDuck.Fly();
Console.WriteLine("-----------END-----------------");


Console.WriteLine("MallardDuck----------START----------------");
MallardDuck mallardDuck = new MallardDuck();
mallardDuck.Quack();
mallardDuck.Display();
mallardDuck.Fly();
Console.WriteLine("-----------END-----------------");


Console.WriteLine("RubberDuck----------START----------------");
RubberDuck rubberDuck = new RubberDuck();
rubberDuck.Quack();
rubberDuck.Display();
rubberDuck.Fly();
Console.WriteLine("-----------END-----------------");


