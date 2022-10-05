namespace DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

public class Whip: CondimentDecorator
{
    public Whip(Beverage.Beverage beverage)
    {
        _beverage = beverage;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Whip";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .40;
    }
}