using System;

namespace td_01

{
    public class Exercice3
    {
        public static string SearchVowels(string inputForVowel)
        {
            int i = 0; //declarer un compteur que je nomme i pour les voyelles
            string vowels = "aeiouyAEIOUY"; // Ici je déclare une variable qui contient toutes les voyelles en majuscule et minuscule

            foreach (char carToSeach in inputForVowel) // Je fais une boucle pour parcourir chaque caractère de la chaine de caractère
            {
                if (vowels.Contains(carToSeach)) // Si la variable vowels contient le caractère alors j'incrémente le compteur i
                {
                    i++; // J'incrémente le compteur i
                }
            }
            Console.WriteLine("Réponse à l'exercice 3: " + i); // J'affiche le nombre de voyelles
            return i.ToString(); // Je retourne le nombre de voyelles

        }

    }
}
