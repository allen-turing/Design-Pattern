namespace StrategyPattern.Ducks.Quack.Fly;

public class FlyRocketPowered: IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I am flying with Rocket");
    }
}