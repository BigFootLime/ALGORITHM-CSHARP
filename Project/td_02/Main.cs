namespace td_02;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Exercice 1
        //(0 °C × 9/5) + 32 = 32 °F


        Console.WriteLine("Entrez une température en degrés Celsius:"); // Console affiche le message
        string? input = Console.ReadLine(); // L'utilisateur entre une valeur
        try
        {
            Exercice1.ConvertCelsiusToFahrenheit(input); // Appel de la méthode ConvertCelsiusToFahrenheit de la classe Exercice1
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur: Entrez un nombre valide.");
        }


        //Exercice 2
        Console.WriteLine("Entrez le premier nombre:");
        string? inputNo1 = Console.ReadLine();
        Console.WriteLine("Entrez le second nombre:");
        string? inputNo2 = Console.ReadLine();
        Console.WriteLine("Entrez le troisième nombre:");
        string? inputNo3 = Console.ReadLine();
        int[] numbers = [Convert.ToInt32(inputNo1), Convert.ToInt32(inputNo2), Convert.ToInt32(inputNo3)];
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        float average = (float)sum / numbers.Length;
        Console.WriteLine("La moyenne est: " + average);

        //Exercice 3 
        Console.WriteLine("Entrez un nombre:");
        string? inputExo3 = Console.ReadLine();
        try
        {
            int convertedInput = Convert.ToInt32(inputExo3);
            if (convertedInput % 2 == 0)
            {
                Console.WriteLine("Réponse à l'exercice 3: Le nombre saisis est pair");
            }
            else
            {
                Console.WriteLine("Réponse à l'exercice 3: Le nombre saisis est impair");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur: Entrez un nombre valide.");
        }

        // CORRECTION 
        //Pour simplifier: string str = n % 2 == 0 ? "pair" : "impair";

        //Exercice 4
        Console.WriteLine("Entrez un nombre:");
        double inputExo4 = Convert.ToDouble(Console.ReadLine());
        try
        {
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine("Réponse à l'exercice 4 " + inputExo4 * i);
            }

        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur: Entrez un nombre valide.");
        }

        Console.WriteLine("Entrez un nombre entier:");
        string? inputExo5 = Console.ReadLine();

        try
        {
            int sumExo5 = 0;
            int convertedInput = Convert.ToInt32(inputExo5);
            for (int i = 1; i <= convertedInput; i++)
            {
                sumExo5 += i;
            }
            Console.WriteLine("Result: " + sumExo5);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur: Entrez un nombre valide.");
        }

    }
}
