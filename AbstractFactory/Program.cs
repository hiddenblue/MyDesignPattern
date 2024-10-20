using Strategy.Models;

namespace Strategy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        PizzaStore nyPizzaStore = new NYPizzaStore();
        
        Pizza pizza = nyPizzaStore.OrderPizza("cheese");

    }
}

/*
public class SimplePizzaFactory
{
    public Pizza CreatePizza(string type)
    {
        Pizza pizza = null;
        
        switch (type)
        {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "greek":
                pizza = new GreekPizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            default:
                return null;
                break;
        } 
        return pizza;
    }
}


public class PizzaStore
{
    private SimplePizzaFactory _factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        _factory = factory;
    }

    public Pizza OrderPizza(string type)
    {
        Pizza pizza;
        
        pizza = _factory.CreatePizza(type);
        
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
}

*/

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza;

        pizza = CreatePizza(type);
        
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;

    }
    
    // abstrat Product factoryMethod(string type)
    protected abstract Pizza CreatePizza(string type);
}

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        switch (item)
        {
            case "cheese":
                return new NYStyleCheesePizza();
            case "pepperoni":
                return new NYStylePepperoniPizza();
            case "veggie":
                return new NYStyleVeggiePizza();
            default:
                return null;
        } 
    }
}

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        Pizza pizza;

        switch (item)
        {
            case "cheese":
                return new ChicagoCheesePizza();
            case "pepperoni":
                return new ChicagoPepperoniPizza();
            case "veggie":
                return new ChicagoVeggiePizza();
            default:
                return null;
        }
    }
}




