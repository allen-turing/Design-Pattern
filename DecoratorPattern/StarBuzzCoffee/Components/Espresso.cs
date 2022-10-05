namespace DecoratorPattern.StarBuzzCoffee.Components;

public class Espresso : Beverage.Beverage
{
    public Espresso()
    {
        _description = "Espresso Coffee";
    }
    public override double Cost()
    {
        return 1.99;
    }
}