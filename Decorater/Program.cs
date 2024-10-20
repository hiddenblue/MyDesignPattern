namespace Decorater;

class Program
{
    static void Main(string[] args)
    {
        Beverage beverage = new Mocha(new Espresso());

        Console.WriteLine(beverage.GetDescription());
        Console.WriteLine(beverage.Cost());


        beverage = new Mocha(beverage);
        Console.WriteLine(beverage.GetDescription()); 
        Console.WriteLine(beverage.Cost());
                
    }
}

public abstract class Beverage
{
    public string Desscription =  "Unknown Beverage";
    
    public string GetDescription() => Desscription;
    
    public abstract double Cost();
}

public abstract class CondimentDecorator : Beverage
{
    public Beverage Beverage;
    
    public abstract string GetDescription();
}

public class Espresso : Beverage
{
    public Espresso()
    {
        Desscription = "Espresso";
    }

    public override double Cost() => 1.99;
}

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        this.Beverage = beverage;
    }

    public override string GetDescription() => this.Beverage.GetDescription() + " Mocha";

    public override double Cost() => Beverage.Cost() + 0.20;
}

