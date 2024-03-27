using System;
using System.Collections.Generic;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mainMenu = new List<string> // Ici on crée une liste de string qui contient les options du menu principal
            {


            };

            List<string> words = new List<string> { "pomme", "camion", "dylan", "csharp", "dotnet", "orange", "burger" }; // Ici on crée une liste de string qui contient les mots à deviner

            List<string> penduDrawings = new List<string> // Ici on crée une liste de string qui affiche ls unes après les autres la personne pendu.
            {
                "",
                "=========\n",
                "       |\n       |\n       |\n       |\n       |\n=========",
                "   +---+\n       |\n       |\n       |\n       |\n       |\n=========",
                "   +---+\n   |   |\n       |\n       |\n       |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n       |\n       |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n   |   |\n       |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n  /|   |\n       |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n  /|\\  |\n       |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n  /|\\  |\n  /    |\n       |\n=========",
                "   +---+\n   |   |\n   O   |\n  /|\\  |\n  / \\  |\n       |\n=========",

            };
            penduDrawings.Reverse(); // Ici on inverse l'ordre des éléments de la liste penduDrawings


            bool playAgain = true; // Ici on initialise la variable playAgain à true pour permettre au joueur de rejouer
            while (playAgain) // Ici on crée une boucle qui s'execute en continue tant que le joueur veut rejouer
            {
                Random random = new Random(); // Ici on crée une nouvelle instance de la classe Random pour pouvoir selectionner un des mots dans la liste words
                string secretWord = words[random.Next(words.Count)]; // Ici on selectionne un mot aléatoire dans la liste words
                HashSet<char> guessedLetters = new HashSet<char>(); // Ici on crée un HashSet pour stocker les lettres devinées par le joueur
                int attemptsLeft = penduDrawings.Count; // Ici on initialise le nombre de tentatives restantes du joueur au nombre de dessins du pendu
                string currentDisplay = new string('_', secretWord.Length * 2 - 1); // Ici on crée une chaine de caractères qui contient des underscores pour chaque lettre du mot secret

                Console.WriteLine("Bienvenue au pendu! Devinez le mot ou tapez 'q' pour quitter."); // Ici on affiche un message de bienvenue

                while (attemptsLeft > 0 && currentDisplay.Contains('_')) // Ici on crée une boucle qui s'execute en continue tant que le joueur n'a pas trouvé le mot secret
                {
                    Console.WriteLine($"Mot: {currentDisplay}"); // Ici on affiche le mot secret avec les lettres devinées par le joueur
                    Console.WriteLine(penduDrawings[attemptsLeft - 1]); // Ici on affiche le dessin du pendu correspondant au nombre de tentatives restantes et on baisse de 1 pour afficher le bon dessin
                    Console.WriteLine($"Tentatives restantes: {attemptsLeft}"); // Ici on affiche le nombre de tentatives restantes
                    Console.Write("Devinez une lettre: "); // Ici on demande au joueur de deviner une lettre
                    string input = Console.ReadLine().ToLower(); // Ici on récupère l'input entré par le joueur et on le met en minuscule

                    if (input == "q") // Ici on vérifie si le joueur a saisi 'q' pour quitter le jeu
                    {
                        Console.WriteLine("Au revoir..."); // Ici on affiche un message de sortie
                        return; // Ici on sort de la boucle et on termine le jeu
                    }

                    if (input.Length != 1 || !char.IsLetter(input[0])) // Ici on vérifie si le joueur a entré plus d'une lettre ou si ce n'est pas une lettre
                    {
                        Console.WriteLine("Erreur: Veuillez entrer qu'une seule lettre."); // Ici on affiche un message d'erreur
                        continue; // Ici on passe à l'itération suivante de la boucle
                    }

                    char guessedLetter = input[0]; // Ici on stocke la lettre devinée par le joueur
                    if (guessedLetters.Contains(guessedLetter)) // Ici on vérifie si le joueur a déjà entré cette lettre
                    {
                        Console.WriteLine("Vous avez déjà entré cette lettre, veuillez réessayer."); // Ici on affiche un message d'erreur
                        continue; // Ici on passe à l'itération suivante de la boucle
                    }

                    guessedLetters.Add(guessedLetter); // Ici on ajoute la lettre devinée par le joueur dans le HashSet guessedLetters

                    if (secretWord.Contains(guessedLetter)) // Ici on vérifie si la lettre devinée par le joueur est dans le mot secret
                    {
                        Console.WriteLine("Correcte!"); // Ici on affiche un message pour indiquer que la lettre est correcte
                        for (int i = 0; i < secretWord.Length; i++) // Ici on crée une boucle qui s'execute pour chaque lettre du mot secret
                        {
                            if (secretWord[i] == guessedLetter) // Ici on vérifie si la lettre du mot secret est égale à la lettre devinée par le joueur
                            {
                                currentDisplay = currentDisplay.Remove(i * 2, 1).Insert(i * 2, guessedLetter.ToString());// Ici on remplace l'underscore par la lettre devinée par le joueur
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, réessayez! "); // Ici on affiche un message pour indiquer que la lettre est incorrecte
                        attemptsLeft--; // Ici on décrémente le nombre de tentatives restantes du joueur
                    }
                }

                if (attemptsLeft > 0)
                {
                    Console.WriteLine($"Bravo! Vous avez trouvé le mot secret: {secretWord} en {penduDrawings.Count - attemptsLeft} tentatives.");
                }
                else
                {
                    Console.WriteLine("Vous avez atteint le nombre maximum de vos tentatives. Vous avez perdu.");
                    Console.WriteLine($"Le mot était: {secretWord}");
                    Console.WriteLine(penduDrawings[0]);
                }

                Console.WriteLine("Merci d'avoir joué! A bientôt!");
                Console.WriteLine("Voulez-vous rejouer? (o/n)");
                string playAgainInput = Console.ReadLine().ToLower();
                playAgain = playAgainInput == "o";
            }
        }
    }
}
