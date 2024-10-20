namespace Decorater;

public interface IQuackBehavior
{
    public void Quack();
}

public class QuackNormal : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!"); 
    }
}

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("<< Silence >>"); 
    }
}

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak!"); 
    }
}