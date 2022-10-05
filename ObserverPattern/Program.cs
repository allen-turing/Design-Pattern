// See https://aka.ms/new-console-template for more information

using ObserverPattern.Display;
using ObserverPattern.Subject;

Console.WriteLine("-----------ObserverPattern----------------");

WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80,65,30.4f);
weatherData.SetMeasurements(82,70,29.2f);
weatherData.SetMeasurements(78,90,29.2f);