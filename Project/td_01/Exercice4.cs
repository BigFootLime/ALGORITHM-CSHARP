using System;

namespace td_01
{
    public static class Exercice4
    {
        public static int SumofArray(int[] array) // Je déclare une méthode qui prend en paramètre un tableau d'entier
        {
            int sum = 0; // Je déclare une variable que je nomme sum et qui contiendra la somme des éléments du tableau
            foreach (int i in array) // Je fais une boucle pour parcourir chaque élément du tableau
            {
                sum += i; // J'additionne chaque élément du tableau à la variable sum
            }
            Console.WriteLine("Réponse à l'exercice 4: " + sum); // Ici J'affiche la somme des éléments du tableau
            return sum; // Je retourne la somme des éléments du tableau
        }
    }
}