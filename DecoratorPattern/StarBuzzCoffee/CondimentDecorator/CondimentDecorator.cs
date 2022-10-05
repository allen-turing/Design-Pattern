namespace DecoratorPattern.StarBuzzCoffee.CondimentDecorator;

public abstract class CondimentDecorator: Beverage.Beverage
{
    public Beverage.Beverage _beverage;

    public abstract override string GetDescription();

}