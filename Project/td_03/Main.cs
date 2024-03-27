using System;

namespace td_03;

class Program
{
    static void Main(string[] args)
    {
        //Exercice1
        Console.WriteLine("Entrez une suite de mots :");
        string? chaine = Console.ReadLine();
        string? result = Exercice1.GetFirstAndLastChar(chaine);
        Console.WriteLine(result);

        //Exercice2
        Console.WriteLine("Commencement de l'exercice 2");
        int[] arrayExo2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        ShuffleArray(arrayExo2);

        foreach (var item in arrayExo2)
        {
            Console.WriteLine(item);
        }

        //Exercice3
        Console.WriteLine("Entrez un nombre :");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Exercice3.GetPosOrNeg(number);
        }
        catch (Exception)
        {
            Console.WriteLine("Veuillez entrer un nombre valide");
        }

        //Exercice4
        Console.WriteLine("Commencement de l'exercice 4");



    }

    // CORRECTION

    //Exercice2
    static void ShuffleArray(int[] array)
    {
        Random shuffle = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int selectRandomIndex = shuffle.Next(array.Length); // Random.Next permet de retourner un nombre aléatoire entre 0 et la valeur passée en paramètre
            int nextArray = array[i]; // On stocke la valeur actuelle de l'index i
            array[i] = array[selectRandomIndex]; // On remplace la valeur actuelle de l'index i par la valeur de l'index aléatoire
            array[selectRandomIndex] = nextArray; // On remplace la valeur de l'index aléatoire par la valeur actuelle de l'index i
        }
    }

}
