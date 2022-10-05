namespace DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

public class Soy: CondimentDecorator
{
    public Soy(Beverage.Beverage beverage)
    {
        _beverage = beverage;
    }
    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }
    public override double Cost()
    {
        return _beverage.Cost() + .30;
    }
}