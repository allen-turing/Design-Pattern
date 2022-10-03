namespace NaiveDuck;

public class Duck
{
    public void Quack()
    {
        Console.WriteLine("Duck -> Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Duck -> Swim");
    }

    public void Display()
    {
        Console.WriteLine("Duck -> Display");
    }
    
    public virtual void Display2()
    {
        Console.WriteLine("Duck -> Display2");
    }
    public virtual void Display3()
    {
        Console.WriteLine("Duck -> Display3");
    }
    public void Fly()
    {
        Console.WriteLine("Duck -> Fly");
    }
}