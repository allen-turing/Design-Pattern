namespace DecoratorPattern.StarBuzzCoffee.Components;

public class Decaf : Beverage.Beverage
{
    public Decaf()
    {
        _description = "Decaf Coffee";
    }
    public override double Cost()
    {
        return .79;
    }
}