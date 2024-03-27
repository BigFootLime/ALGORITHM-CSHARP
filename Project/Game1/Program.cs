using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Random getRandomNumber = new Random(); // Ici on crée une nouvelle instance de la classe Random pour pouvoir generer des nombres aléatoires
                int secretNumber = getRandomNumber.Next(1, 10001); // Ici on génère un nombre aléatoire entre 1 et 10000
                // Console.WriteLine(secretNumber);  Ici on affiche le nombre secret pour tester
                int playerAttempts = 0; // Ici on initialise le nombre de tentatives du joueur à 0
                int playerMaxAttempts = 15; // Ici on initialise le nombre de tentatives maximum du joueur à 10
                bool playerHasWon = false; // Ici on initialise la variable qui indique si le joueur a gagné ou non à false

                Console.WriteLine("Bienvenue dans le jeu du juste prix.... Devinez le nombre secret pour gagner un Kinder ;) Bonne chance!!"); // Ici on affiche un message de bienvenue
                Console.WriteLine("Vous avez droit à 10 tentatives pour trouver le nombre secret"); // Ici on affiche  un message qui indique le nombre de tentatives maximum du joueur

                // Ici on crée une boucle qui s'execute en continue tant que le joueur n'a pas gagné et que son nombre de tentatives est inferieur au nombre tentatives données.
                while (playerHasWon == false && playerAttempts < playerMaxAttempts)
                {
                    Console.WriteLine("Entrez un nombre entre 1 et 10000: "); // Ici on demande au joueur d'entrer un nombre
                    string playerInput = Console.ReadLine(); // Ici on récupère l'input entré par le joueur

                    if (playerInput == "q") // Ici on vérifie si le joueur a saisi 'q' pour quitter le jeu.
                    {
                        Console.WriteLine("Oh non! Vous partez si tôt. Ne rage quittez pas voyons!"); // Ici on affiche un message de sortie.
                        break; // Sort de la boucle, mettant fin au jeu.
                    }

                    playerAttempts++; // Ici on incrémente le compteur de tentatives à chaque essai.
                    int playerGuessedNumber; // Ici on crée une variable pour stocker le nombre saisi par le joueur

                    // Ici on vérifie si l'input du joueur est un nombre et si c'est le cas, on le stocke dans la variable playerGuessedNumber             
                    if (int.TryParse(playerInput, out playerGuessedNumber))
                    {
                        if (playerGuessedNumber > 10000) // Ici on vérifie si le nombre saisi par le joueur est plus grand que le nombre maximal possible
                        {
                            Console.WriteLine("Erreur: Votre nombre est plus grand que le nombre maximal possible. Cela vous coûte 2 tentatives!"); // Ici on affiche un message indiquant que ca coutera 2 tentatives au joueur
                            playerAttempts += 1; // Ici on incrémente le nombre de tentatives du joueur de 2
                        }

                        else if (playerGuessedNumber < 1)
                        {
                            Console.WriteLine("Erreur: Votre nombre est plus petit que le nombre minimal possible. Cela vous coûte 2 tentatives!");
                            playerAttempts += 1; // Ici on incrémente le nombre de tentatives du joueur de 2
                        }

                        if (playerGuessedNumber == secretNumber) // Ici on vérifie si le nombre saisi par le joueur est égal au nombre secret
                        {
                            playerHasWon = true; // Ici on met la variable playerHasWon à true pour indiquer que le joueur a gagné
                            Console.WriteLine("Bravo! Vous avez trouvé le nombre secret en " + playerAttempts + " tentatives"); // Ici on affiche un message de félicitations
                            break; // Ici on sort de la boucle
                        }
                        else if (playerGuessedNumber < secretNumber) // Ici on vérifie si le nombre saisi par le joueur est plus petit que le nombre secret
                        {
                            // Ici on affiche un message pour indiquer que le nombre secret est plus grand que le nombre saisi par le joueur
                            Console.WriteLine("Le nombre secret est plus grand que " + playerGuessedNumber);
                            Console.WriteLine("Il vous reste " + (playerMaxAttempts - playerAttempts) + " tentatives"); // Ici on affiche le nombre de tentatives restantes
                        }
                        else
                        {
                            // Ici on affiche un message pour indiquer que le nombre secret est plus petit que le nombre saisi par le joueur
                            Console.WriteLine("Le nombre secret est plus petit que " + playerGuessedNumber);
                            Console.WriteLine("Il vous reste " + (playerMaxAttempts - playerAttempts) + " tentatives"); // Ici on affiche le nombre de tentatives restantes
                        }
                    }
                    else
                    {
                        // Ici on affiche un message d'erreur si le joueur n'a pas saisi un nombre valide                                      
                        Console.WriteLine("Erreur: Veuillez entrer un nombre valide entre 1 et 10000. Cela vous coûte 4 tentative!");
                        playerAttempts += 3;
                        Console.WriteLine("Il vous reste " + (playerMaxAttempts - playerAttempts) + " tentatives");
                    }
                    if (playerAttempts == playerMaxAttempts) // Ici on vérifie si le joueur a atteint le nombre maximum de tentatives
                    {
                        Console.WriteLine("Vous avez atteint le nombre maximum de vos tentatives. Vous avez perdu."); // Ici on affiche un message de perte.
                        break; // Sort de la boucle, le joueur a perdu.
                    }
                }
                Console.WriteLine("Merci d'avoir joué! A bientôt!"); // Ici on affiche un message de fin de jeu
                Console.WriteLine("Voulez-vous rejouer? (o/n)"); // Ici la console affiche un message pour demander au joueur s'il veut rejouer
                string replay = Console.ReadLine(); // ici on récupère la réponse du joueur
                if (replay.ToLower() != "o") // Ici on vérifie si la réponse du joueur est différente de 'o'
                {
                    playAgain = false; // Ici on met la variable playAgain à false pour sortir de la boucle principale
                }
            }
        }

    }
}