namespace StrategyPattern.Ducks.Quack;

public class MuteQuack: IQuackBehavior
{
    public void quack()
    {
        Console.WriteLine("I can't Quack");
    }
}