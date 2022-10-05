using System.Security.Cryptography;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.Display;

public class StatisticsDisplay : IDisplay, IObserver
{
    private float _maxTemp = 0.0f;
    private float _minTemp = 200;
    private float _tempSum = 0.0f;
    private int _numReadings;
    private WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    
    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {_tempSum/_numReadings}/{_maxTemp}/{_minTemp}");
    }
    public void Update(float temp,float humidity,float pressure)
    {
        _tempSum += temp;
        _numReadings++;

        if (temp > _maxTemp)
        {
            _maxTemp = temp;
        }

        if (temp < _minTemp)
        {
            _minTemp = temp;
        }

        Display();
    }
}