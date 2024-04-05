using System;
using System.Collections.Generic;

public namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static void StartHangmanGame()
        {
//  List<string> easyWords = new List<string> { "apple", "truck", "chips", "csharp", "dotnet", "orange", "burger" }; // Create a list of easy words for the game
//             List<string> mediumWords = new List<string> { "avocado", "tractor", "pineapple", "javascript", "bear", "hotdog" }; // Create a list of medium words for the game
//             List<string> hardWords = new List<string> { "dragonfruit", "transporter", "raddish", "microsoft", "elephant", "mcdonalds" };// Create a list of hard words for the game

            // List<string> menuOptions = new List<string> { "Easy", "Medium", "Hard" }; // Create a list of menu options for the player to choose the difficulty level
            // DisplayMainMenuPendu(menuOptions); // Display the main menu for the player to choose the difficulty level
            // int difficulty = Convert.ToInt32(Console.ReadLine()); // Read the player's input for the difficulty level

            // List<string> words; // Declare a list of words to store the words based on the player's chosen difficulty level
            // switch (difficulty) // Check the player's chosen difficulty level
            // {
            //     case 1: // If the player chose Easy
            //         words = easyWords; // Set the words list to the list of easy words
            //         break;
            //     case 2: // If the player chose Medium
            //         words = mediumWords; // Set the words list to the list of medium words
            //         break;
            //     case 3: // If the player chose Hard
            //         words = hardWords; // Set the words list to the list of hard words
            //         break;
            //     default: // If the player chose an invalid option
            //         Console.WriteLine("Invalid option. Defaulting to Easy."); // Display an error message to the player
            //         words = easyWords; // Set the words list to the list of easy words
            //         break;
            // }
           List<string> words = new List<string> { "apple", "truck", "chips", "csharp", "dotnet", "orange", "burger" };

            List<string> penduDrawings = new List<string> // Create a list of drawings for the hangman game
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
            penduDrawings.Reverse(); // Reverse the list of drawings to display the hangman from top to bottom

            bool playAgain = true; // Initialize the variable to play the game again to true
            while (playAgain) // Continue playing the game until the player chooses to quit
            {
                Random random = new Random(); // Create a new instance of the Random class to generate random numbers
                string secretWord = words[random.Next(words.Count)]; // Select a random word from the list of words
                HashSet<char> guessedLetters = new HashSet<char>(); // Create a hash set to store the guessed letters
                int attemptsLeft = penduDrawings.Count; // Initialize the number of attempts left to the number of drawings
                string currentDisplay = new string('_', secretWord.Length * 2 - 1); // Initialize the current display of the word with underscores

                Console.WriteLine("Welcome to Hangman! Guess the word or type 'q' to quit."); // Display a welcome message to the player

                while (attemptsLeft > 0 && currentDisplay.Contains('_')) // Continue the game until the player wins or runs out of attempts
                {
                    Console.WriteLine($"Word: {currentDisplay}"); // Display the current state of the word
                    Console.WriteLine(penduDrawings[attemptsLeft - 1]); // Display the current state of the hangman
                    Console.WriteLine($"Attempts left: {attemptsLeft}"); // Display the number of attempts left
                    Console.Write("Guess a letter: "); // The console asks the player to guess a letter
                    string input = Console.ReadLine().ToLower(); // the console reads the player's input and converts it to lowercase

                    if (input == "quitter" && currentDisplay.Contains('_')) // If the player types 'quitter' and the word has not been guessed
                    {
                        Console.WriteLine("Goodbye..."); // Display a goodbye message to the player
                        return; // Exit the game
                    }

                    if (input.Length != 1) // If the player enters more than one letter
                    {
                        Console.WriteLine("Error: Please enter only one letter."); // Display an error message to the player
                        continue; // Skip the rest of the code and restart the loop
                    }                

                    if(!char.IsLetter(input[0])) // If the player enters a non-letter character
                    {
                        Console.WriteLine("Error: Please enter a letter."); // Display an error message to the player
                        continue; // Skip the rest of the code and restart the loop
                    }
                   
                    char guessedLetter = input[0]; // Get the guessed letter from the player's input
                    if (guessedLetters.Contains(guessedLetter)) // If the player has already guessed the letter
                    {
                        Console.WriteLine("You have already entered this letter, please try again."); // Display an error message to the player
                        continue;
                    }

                    guessedLetters.Add(guessedLetter); // Add the guessed letter to the set of guessed letters

                    if (secretWord.Contains(guessedLetter)) // If the guessed letter is in the secret word
                    {
                        Console.WriteLine("Correct!"); // Display a message to the player
                        for (int i = 0; i < secretWord.Length; i++) // Iterate through the secret word
                        {
                            if (secretWord[i] == guessedLetter) // If the letter at the current index matches the guessed letter
                            {
                                currentDisplay = currentDisplay.Remove(i * 2, 1).Insert(i * 2, guessedLetter.ToString()); // Update the current display with the guessed letter
                            }
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, try again!"); // console displays a message to the player
                        attemptsLeft--; // Decrease the number of attempts left
                    }
                }

                if (attemptsLeft > 0) // If the player wins the game
                {
                    Console.WriteLine($"Congratulations! You found the secret word: {secretWord} in {penduDrawings.Count - attemptsLeft} attempts."); // Display a message to the player
                }
                else
                {
                    Console.WriteLine("You have reached the maximum number of your attempts. You lost."); // Display a message to the player
                    Console.WriteLine($"The word was: {secretWord}"); // Display the secret word to the player
                    Console.WriteLine(penduDrawings[0]); // Display the hangman drawing to the player
                }

                Console.WriteLine("Thank you for playing! See you soon!"); // Display a thank you message to the player
                Console.WriteLine("Do you want to play again? (y/n)"); // Asks the user if they want to play again
                string? replay = Console.ReadLine(); // Reads the player's input to play again
                if (replay?.ToLower() != "y") // If the player does not want to play again
                {
                    playAgain = false; // Set the play again variable to false to exit the game
                }
            }
        }
    }
}