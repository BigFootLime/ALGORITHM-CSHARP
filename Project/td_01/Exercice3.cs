using System;

namespace td_01

{
    public class Exercice3
    {
        public static void SearchVowels(string inputForVowel)
        {
            int i = 0;
            string vowels = "aeiouAEIOU";

            foreach (char caracter in inputForVowel)
            {
                if (vowels.Contains(caracter))
                {
                    i++;
                }
            }

            Console.WriteLine("Réponse à l'exercice 3: " + i);
        }
    }
}
