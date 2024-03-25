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

            // Exercice2
            string input = "Hello, World!";
            string reversed = Exercice2.ReverseString(input);
            Console.WriteLine("Réponse à l'exercice 2: " + reversed);

            // Exercice3
            string inputForVowel = "I like carrot soup with a fully grilled steak ";
            Exercice3.SearchVowels(inputForVowel);

            // Exercice4
            int[] array = { 1, 2, 3, 4, 12 };
            int sum = Exercice4.SumArray(array);

            // Exercice5
            int[] arrayForMax = { 1, 18, 3, 4, 12 };
            int max = Exercice5.MaxArray(arrayForMax);

        }

    }
}
