namespace DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage.Beverage beverage)
    {
        _beverage = beverage;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Mocha";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .20;
    }
}