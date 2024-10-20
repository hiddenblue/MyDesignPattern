using System.Text;

namespace Builder;

class Program
{
    static void Main(string[] args)
    {
       ConcreteBuilder builder = new ConcreteBuilder(); 
       Director director = new Director();
       
       director.Builder = builder;
       director.BuildPartA();
       
       builder.GetProduct().ListParts();
       
       director.BuildAllParts();
       builder.GetProduct().ListParts();

       StringBuilder sb = new();

       sb.Append("666");

    }
}

public interface IBuilder
{
    void BuildPartA();
    void BuildPartB();
    void BuildPartC();
}

public class Product
{
    private List<object> _parts = new();
    
    public void Add(string part) => _parts.Add(part);

    public void ListParts()
    {
        _parts.ForEach(Console.Write);
        Console.WriteLine();
    }
}

public class ConcreteBuilder : IBuilder
{
    private Product _product = new();
    
    private void Reset() => _product = new();


    public void BuildPartA()
    {
        this._product.Add("PartA");
    }

    public void BuildPartB()
    {
        this._product.Add("PartB");
    }

    public void BuildPartC()
    {
        this._product.Add("PartC");
    }

    public Product GetProduct()
    {
        Product result = _product;
        Reset();
        return result;
    }
}

public class Director
{
    private IBuilder _builder;
    
    public IBuilder Builder { set => _builder = value; }

    public void BuildPartA()
    {
        this._builder.BuildPartA();
    }

    public void BuildAllParts()
    {
        this._builder.BuildPartA();
        this._builder.BuildPartB();
        this._builder.BuildPartC();
    }
}


