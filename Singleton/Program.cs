namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        
        var instance = ChocolateBoiler.Instance;
        var instance2 = ChocolateBoiler.Instance;

        if (instance == instance2)
            Console.WriteLine("Instance is the same instance");
    }
}

public class ChocolateBoiler
{
    private ChocolateBoiler()
    {
        _empty = true;
        _boiled = false;
    }

    public static ChocolateBoiler Instance { get; } = new();
    
    private bool _empty;
    private bool _boiled;
    
    public bool IsEmpty() => _empty;
    public bool IsBoiled() => _boiled;
    
    public void Fill()
    {
        if (!IsEmpty())
        {
            _empty = false;
            _boiled = false;
        }
    }

    public void Boil()
    {
        if (!IsEmpty() && !_boiled)
        {
            _boiled = true;
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            _empty = true;
        }
    }
    
    
}