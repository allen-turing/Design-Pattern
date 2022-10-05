namespace DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

public class Milk: CondimentDecorator
{
    public Milk(Beverage.Beverage beverage)
    {
        _beverage = beverage;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Milk";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .50;
    }
}