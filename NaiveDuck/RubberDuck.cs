namespace NaiveDuck;

public class RubberDuck : Duck
{
    public new void Display()
    {
        Console.WriteLine("Duck Rubber -> Display");
    }

    public new void Quack()
    {
        Console.WriteLine("Duck Rubber -> I Squeak");
    }
    public new void Fly()
    {
        Console.WriteLine("Duck Rubber -> I don't fly");
    }
}