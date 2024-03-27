using System;
namespace td_01
{
    public static class Exercice5
    {
        public static int MaxArray(int[] arrayforMax) // Je déclare une méthode MaxArray qui prend en paramètre un tableau d'entier
        {
            int max = 0; // Je déclare une variable max initialisée à 0
            foreach (int i in arrayforMax) // Pour chaque élément i du tableau arrayforMax
            {
                if (i > max) // Si i est supérieur à max
                {
                    max = i; // Alors max prend la valeur de i
                }
            }
            Console.WriteLine("Réponse à l'exercice 5: " + max); // J'affiche la valeur de max
            return max; // Je retourne la valeur de max
        }
    }
}