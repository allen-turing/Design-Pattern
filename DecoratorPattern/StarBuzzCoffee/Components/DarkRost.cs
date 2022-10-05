namespace DecoratorPattern.StarBuzzCoffee.Components;

public class DarkRost : Beverage.Beverage
{
    public DarkRost()
    {
        _description = "Dark Roast Coffee";
    }
    public override double Cost()
    {
        return .92;
    }
}