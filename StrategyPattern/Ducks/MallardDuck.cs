using StrategyPattern.Ducks.Quack;
using StrategyPattern.Ducks.Quack.Fly;

namespace StrategyPattern.Ducks;

public class MallardDuck : Duck
{
    // public MallardDuck()
    // {
    //     quackBehavior = new Quack();
    //     flyBehavior = new FlyWithWIngs();
    // }

    public MallardDuck(IFlyBehavior flyBehavior,IQuackBehavior quackBehavior)
    {
        this.flyBehavior = flyBehavior;
        this.quackBehavior = quackBehavior;
    }

    public new void Display()
    {
        Console.WriteLine("I am a real Mallard Duck!");
    }
}