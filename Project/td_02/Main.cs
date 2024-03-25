namespace td_02;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 1
        //(0 °C × 9/5) + 32 = 32 °F
        Console.WriteLine("Entrez une température en degrés Celsius:");
        string? input = Console.ReadLine();
        double celsius = Convert.ToDouble(input);
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Réponse à l'exercice 1: " + celsius + "°C = " + fahrenheit + " °F");

        //Exercice 2
        Console.WriteLine("Entrez le premier nombre:");
        string? inputNo1 = Console.ReadLine();
        Console.WriteLine("Entrez le second nombre:");
        string? inputNo2 = Console.ReadLine();
        Console.WriteLine("Entrez le troisième nombre:");
        string? inputNo3 = Console.ReadLine();
        int[] numbers = { Convert.ToInt32(inputNo1), Convert.ToInt32(inputNo2), Convert.ToInt32(inputNo3) };
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        float average = (float)sum / numbers.Length;
        Console.WriteLine("La moyenne est: " + average);


    }
}
