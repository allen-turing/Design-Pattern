namespace DecoratorPattern.StarBuzzCoffee.Beverage;

public abstract class Beverage
{
    public string _description = "Unknown Beverage";
    public virtual string GetDescription()
    {
        return _description;
    }

    public abstract double Cost();
}