using System;

namespace td_01
{
    public class Exercice1
    {
        public static void Search(int[] tab, int x)
        {
            bool isFound = false;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] == x)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine(" Réponse à l'exercice 1: true");
            }
            else
            {
                Console.WriteLine("Réponse à l'exercice 1: false");
            }
        }
    }
}
