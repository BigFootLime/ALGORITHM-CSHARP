using System;

namespace td_03;

class Program
{
    static void Main(string[] args)
    {
        //Exercice1
        Console.WriteLine("Entrez une suite de mots :");
        string? input = Console.ReadLine();
        string? result = Exercice1.GetFirstAndLastChar(input);
        Console.WriteLine(result);

        //Exercice2
        Console.WriteLine("Commencement de l'exercice 2");
        int[] arrayExo2 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        Exercice2.ShuffleTable(arrayExo2);

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


}
