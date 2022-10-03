namespace StrategyPattern.Ducks.Quack.Fly;

public class FlyNoWay: IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I can not Fly");
    }
}