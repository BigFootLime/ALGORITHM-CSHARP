using System;


namespace MainMenu
{
    class Program
    {
        public static void Main(string[] args)
        {
             string menu_deco = @"
===================================================================================================
                                                                                                    
                                              WELCOME PLAYER 1                                      
                                                                                                    
        +-------------------+                             +-----------------------------+             
        | Press 'q' to Exit |                             | Press 1: Start Hangman Game |             
        +-------------------+                             +-----------------------------+             
                                                                                                    
                                                          +-----------------------------+              
                                                          | Press 2: Start Guessing Game|              
                                                          +-----------------------------+              
                                                                                                    
===================================================================================================
";
            Console.WriteLine(menu_deco);
            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                 StartHangmanGame(); 
                    
                    break;
                case '2':
                  GuessingGame(); 
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please press 1, 2 or q.");
                    Console.WriteLine("GoodBye");
                    break;
            }


             static void GuessingGame()
            {
                bool inGame = true;
                while (inGame)
                {
                    Random getRandomNumber = new Random(); // Create a new instance of the Random class to generate random numbers
                    int secretNumber = getRandomNumber.Next(1, 10001); // Generate a random number between 1 and 10000
                    int playerAttempts = 0; // Initialize the player's attempt count to 0
                    int playerMaxAttempts = 15; // Initialize the maximum number of attempts for the player to 15
                    bool playerHasWon = false; // Initialize the variable indicating whether the player has won to false

                    Console.WriteLine("Welcome to the guessing game.... Guess the secret number to win a Kinder ;) Good luck!!"); // Display a welcome message to the player
                    Console.WriteLine("You have 15 attempts to find the secret number"); // Display the number of attempts the player has

                    while (!playerHasWon && playerAttempts < playerMaxAttempts) // Continue the game until the player wins or runs out of attempts
                    {
                        Console.WriteLine("Enter a number between 1 and 10000: "); // Prompt the player to enter a number
                        string? playerInput = Console.ReadLine(); // Read the player's input from the console

                        if (playerInput == "q") // Check if the player wants to quit the game
                        {
                            Console.WriteLine("Oh no! You're leaving so soon. Don't rage quit!"); // Display a message to the player
                            inGame = false; // Set the inGame variable to false to exit the game loop
                        }

                        playerAttempts++; // Increment the player's attempt count
                        int playerGuessedNumber;  // Declare a variable to store the player's guessed number

                        if (int.TryParse(playerInput, out playerGuessedNumber)) // Check if the player's input can be parsed as an integer
                        {
                            if (playerGuessedNumber > 10000) // Check if the player's number is larger than the maximum possible number
                            {   
                                Console.WriteLine("Error: Your number is larger than the maximum possible number. This costs you 2 attempts!"); // Display an error message to the player
                                playerAttempts += 1; // Increment the player's attempt count by 2
                            }
                            else if (playerGuessedNumber < 1) // Check if the player's number is smaller than the minimum possible number
                            {
                                Console.WriteLine("Error: Your number is smaller than the minimum possible number. This costs you 2 attempts!"); // Display an error message to the player
                                playerAttempts += 1; // Increment the player's attempt count by 2
                            }
                            else if (playerGuessedNumber == secretNumber) // Check if the player's guessed number matches the secret number
                            {
                                playerHasWon = true; // Set the playerHasWon variable to true
                                Console.WriteLine("Congratulations! You found the secret number in " + playerAttempts + " attempts"); // Display a congratulatory message to the player
                                inGame = false; // Set the inGame variable to false to exit the game loop
                            }
                            else if (playerGuessedNumber < secretNumber) // Check if the player's guessed number is smaller than the secret number
                            {
                                Console.WriteLine("The secret number is larger than " + playerGuessedNumber); // Display a message to the player
                                Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                            }
                            else // If none of the above conditions are met, the player's guessed number is larger than the secret number
                            {
                                Console.WriteLine("The secret number is smaller than " + playerGuessedNumber); // Display a message to the player
                                Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                            }
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter a valid number between 1 and 10000. This costs you 4 attempts!"); // Display an error message to the player
                        playerAttempts += 3; // Increment the player's attempt count by 4
                        Console.WriteLine("You have " + (playerMaxAttempts - playerAttempts) + " attempts left"); // Display the number of attempts the player has left
                    }
                    if (playerAttempts == playerMaxAttempts)  // Check if the player has reached the maximum number of attempts
                    {
                        Console.WriteLine("You have reached the maximum number of attempts. You lost."); // Display a message to the player
                        inGame = false; // Set the inGame variable to false to exit the game loop
                    }
                }
                Console.WriteLine("Thanks for playing! See you soon!"); // Display a message to the player
                Console.WriteLine("Do you want to play again? (y/n)"); // Ask the player if they want to play again
                string replay = Console.ReadLine(); // Read the player's response from the console
                if (replay?.ToLower() != "y") // Check if the player's response is not 'y'
                {
                    inGame = false; // Set the inGame variable to false to exit the game loop
                    Console.WriteLine("Goodbye! See you soon."); // Display a goodbye message to the player
                }
            }
        }

         static void StartHangmanGame()
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
    
}
