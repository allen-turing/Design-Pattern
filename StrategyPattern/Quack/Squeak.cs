namespace StrategyPattern.Ducks.Quack;

public class Squeak: IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("I can Squeak");
    }
}