namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public abstract class WeatherData : ISubject
{
    
    private float temp { get; set; }

    public float GetTemperature()
    {
        return (float)70;
    }
    
    private float pressure { get; set; }

    public float GetPressure()
    {
        return (float)70;
    }
    
    private float humidity { get; set; }

    public float GetHumidity()
    {
        return (float)70;
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temp, float pressure, float humidity)
    {
        this.temp = temp;
        this.pressure = pressure;
        this.humidity = humidity;
    }

    private List<IObserver> _observers = new();

    public void RegisterObserver(IObserver o)
    {
       _observers.Add(o); 
    }

    public void UnregisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void NotifyObservers()
    {
       _observers.ForEach(o => o.Update(temp, pressure, humidity)); 
    }
}

public interface ISubject
{
    public void RegisterObserver(IObserver o);
    
    public void UnregisterObserver(IObserver o);
    
    public void NotifyObservers();
}

public interface IObserver
{
    public void Update(float temp, float pressure, float humidity);
}

public interface IDisplayElement
{
    public void Display();
}

public class CureentConditonsDisplay : IObserver, IDisplayElement
{
    public float temp;
    public float pressure;
    public float humidity;
    
    private WeatherData _weatherData;

    public CureentConditonsDisplay(WeatherData weather)
    {
        this._weatherData = weather;
        weather.RegisterObserver(this);
    }
    
    public void Update(float temp, float pressure, float humidity)
    {
        this.temp = temp;
        this.humidity = humidity;
        this.pressure = pressure;
        Display();
    }

    public void Display()
    {
        throw new NotImplementedException();
    }
}