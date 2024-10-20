using Decorater;

namespace Strategy;

public abstract class Duck
{
    
    public IFlyBehavior FlyBehavior;
    
    public IQuackBehavior QuackBehavior;

    public Duck()
    {
        
    }
    
    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        FlyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        QuackBehavior = qb;
    }


    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new QuackNormal();
        FlyBehavior = new FlyWithWings();
    }


    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        QuackBehavior = new QuackNormal();
        FlyBehavior = new FlyNoWay();
    }


    public override void Display()
    {
        Console.WriteLine("I'm a Model duck");
    }
}


