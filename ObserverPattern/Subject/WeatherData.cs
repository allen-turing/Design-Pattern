using ObserverPattern.Observer;

namespace ObserverPattern.Subject;

public class WeatherData : ISubject
{
    private List<IObserver>? _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }
    public void RegisterObserver(IObserver o)
    {
        _observers?.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers?.Remove(o);
    }

    public void NotifyObserver()
    {
        if (_observers != null)
            foreach (var observer in _observers)
            {
                observer.Update(_temperature,_humidity,_pressure);
            }
    }

    private void MeasurementChanged()
    {
        NotifyObserver();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        
        MeasurementChanged();
    }
}