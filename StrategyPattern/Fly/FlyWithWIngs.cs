namespace StrategyPattern.Ducks.Quack.Fly;

public class FlyWithWIngs: IFlyBehavior
{
    public void fly()
    {
        Console.WriteLine("I can fly with Wings");
    }
}