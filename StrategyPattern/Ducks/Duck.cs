using StrategyPattern.Ducks.Quack;
using StrategyPattern.Ducks.Quack.Fly;

namespace StrategyPattern.Ducks;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {

    }
    public void PerformQuack()
    {
        quackBehavior.quack();
    }
    
    public void PerformFly()
    {
        flyBehavior.fly();
    }
    
    public void SetFlyBehavior(IFlyBehavior fb) {
        flyBehavior = fb;
    }
    
    public void SetQuackBehavior(IQuackBehavior qb) {
        quackBehavior = qb;
    }
    
    public void Swim()
    {
        Console.WriteLine("I can swim");
    }
    
    public void Display()
    {
        Console.WriteLine("I can Display");
    }
}