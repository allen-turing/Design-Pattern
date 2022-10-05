namespace DecoratorPattern.StarBuzzCoffee.Components;

public class HouseBlend : Beverage.Beverage
{
    public HouseBlend()
    {
        _description = "House Blend Coffee";
    }
    public override double Cost()
    {
        return .89;
    }
}