using System.Collections;

namespace Strategy.Models;

public class Pizza
{
    public string Name;

    public string Dough;
    
    public string Sauce;

    public ArrayList Toppings = new();

    public void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Tossingg dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine(topping);
        }
        
    }

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350"); 
    }

    public void Cut()
    {

        Console.WriteLine("Cutting the pizza into diagonal slice");
    }

    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
        
    }
}

public class ChickenPizza : Pizza
{
    
}

public class CheesePizza : Pizza
{
    
}

public class GreekPizza : Pizza
{
    
}

public class PepperoniPizza : Pizza
{
    
}

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        
        Toppings.Add("Grated Reggiano Cheese");
    }
}

public class NYStyleVeggiePizza : Pizza
{
    
}


public class NYStylePepperoniPizza : Pizza
{
    
}

public class ChicagoCheesePizza : Pizza
{
    
}

public class ChicagoVeggiePizza : Pizza
{
    
}

public class ChicagoPepperoniPizza : Pizza
{
    
}
