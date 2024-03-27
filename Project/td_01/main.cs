using System;

namespace td_01
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Exercice 1
            int[] x = { 1, 2, 3, 4, 5 };
            int intToSearch = 4;
            Exercice1.Search(x, intToSearch);

            //CORRECTION: 
            //int[] tab = new[]{ 1, 2, 3, 4, 5 };
            //bool result = Search(4, tab);
            //Console.WriteLine(result);



            // Exercice2
            string inputString = "Hello, World!";
            string reversed = Exercice2.ReverseString(inputString);
            Console.WriteLine("Réponse à l'exercice 2: " + reversed);


            // Exercice3
            string inputForVowel = "I like carrot soup with a fully grilled steak "; // Je déclare une variable qui contient une phrase
            Exercice3.SearchVowels(inputForVowel); // J'appelle la méthode SearchVowels de la classe Exercice3

            // Exercice4
            int[] array = [1, 2, 3, 4, 12]; // Je déclare un tableau d'entier
            Exercice4.SumofArray(array); // J'appelle la méthode SumArray de la classe Exercice4

            // Exercice5
            int[] arrayForMax = { 1, 18, 3, 4, 12 }; // Je déclare un tableau d'entier
            Exercice5.MaxArray(arrayForMax); // J'appelle la méthode MaxArray de la classe Exercice5

        }

    }
}
