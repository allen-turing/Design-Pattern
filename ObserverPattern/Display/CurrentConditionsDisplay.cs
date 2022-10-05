using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.Display;

public class CurrentConditionsDisplay : IDisplay, IObserver
{
    private float _temperature;
    private float _humidity;
    private float _pressure;
    private WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Display()
    {
        Console.WriteLine($"Current Conditions: {_temperature} F degrees with humidity {_humidity} and Pressure {_pressure}");
    }
    public void Update(float temp,float humidity,float pressure)
    {
        _temperature = temp;
        _humidity = humidity;
        _pressure = pressure;
        Display();
    }
}