using System;

namespace td_02;

public class Exercice1
{
    public static double ConvertCelsiusToFahrenheit(string? input)
    {
        double celsius = Convert.ToDouble(input);
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine("Réponse à l'exercice 1: " + celsius + "°C = " + fahrenheit + " °F");
        return fahrenheit;
    }
}