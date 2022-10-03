using StrategyPattern.Ducks.Quack.Fly;

namespace StrategyPattern.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Quack.Quack();
    }
    
}